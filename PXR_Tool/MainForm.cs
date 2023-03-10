using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

using Newtonsoft.Json;

using StasaLibrary;

namespace PXR_Tool
{


    public partial class MainForm : Form
    {
        public static MainForm instance;
        public static string RestoreInfoPath = @"Config/RestoreInfo.txt";

        public DeviceInfo connectedDevice { get { return Program.connectedDevice; } }
        public EtuDevice device = null;

        public string PasswordString { get { return passwordTextbox.Text; } }
        public bool AutoPassword { get { return autoPasswordCheckbox.Checked; } }

        private bool _isInManMo;
        public ParameterGroup EnterManMoPG;
        public ParameterGroup ExitManMoPg;

        public MainForm()
        {
            instance = this;

            device = new EtuDevice("COM4");
            InitializeComponent();


            device.BindComsLog(comsLog);
            connMenu.BindDevice(device);
            device.ConnectedEvent += Device_ConnectedEvent;
            device.DisconnectEvent += Device_DisconnectEvent;

            connMenu.portChecker.PortStateChanged += Handle_PortStateChange;

            Program.DeviceChangedEvent += Program_DeviceChangedEvent;
        }

        private void Program_DeviceChangedEvent(BroadDeviceChangedEventArgs obj)
        {
            toggleManMoButton.Enabled = true;
            switch (Program.currentBDT)
            {
                case DeviceDiscovery.DeviceType.PdPxr20:
                case DeviceDiscovery.DeviceType.PdPxr25:
                    EnterManMoPG = Program.connectedDevice.manufacturingDict[(int)PdDeviceInfo.Manufacturing.EnterManufacturingMode];
                    ExitManMoPg = Program.connectedDevice.manufacturingDict[(int)PdDeviceInfo.Manufacturing.ExitManufacturingMode];
                    break;
                case DeviceDiscovery.DeviceType.Tokyo:
                    EnterManMoPG = Program.connectedDevice.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.EnterManMode];
                    ExitManMoPg = Program.connectedDevice.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.ExitManMode];
                    break;
                default:
                    toggleManMoButton.Enabled = false;
                    break;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            connMenu.WindowsMessage(ref m);
        }

        private void Handle_PortStateChange(PortStateChangeArgs psca)
        {
            connMenu.selectedPortFrame.UpdateComPortList(psca.comDevicesFound);
        }

        #region Inital Reads and Connection Event
        /// <summary>
        /// Called when a device is connected. Will perform some inital reads
        /// TODO: Will detemien precise etu type after reads
        /// </summary>
        /// <param name="obj"></param>
        private async void Device_ConnectedEvent(ConnectionEventArgs obj)
        {
            switch (connMenu.SelectedPortFrame.SelectedComDevice.deviceType)
            {
                case ComDevice.BroadDeviceType.PD:
                    //LoadInfo_PDPXR25();
                    await InitalReads_PD();
                    break;
                case ComDevice.BroadDeviceType.ACB:
                    await InitalReads_ACB();
                    break;
                case ComDevice.BroadDeviceType.Mod:
                    break;
                case ComDevice.BroadDeviceType.Other:
                    await InitalReads_PXR35();
                    break;
            }
        }

        /// <summary>
        /// Updates lables below connect frame with connected device info
        /// </summary>
        private void UpdateConnectedDeviceInfo()
        {
            ratingLabel.Text = connectedDevice.Rating.ToString();
            frameLabel.Text = connectedDevice.frame;
            typeLabel.Text = connectedDevice.StyleString;
        }

        private async Task InitalReads_PD()
        {
            // Rating
            EtuRequest req = connectedDevice.GetConfigPG(PdDeviceInfo.Configurations.Breaker_Rating).ReadRequest();
            EtuResponse res = await AsyncTransaction(req);
            if (res.goodResponse)
                connectedDevice.Rating = res.IntValues[0];
            else
                connectedDevice.Rating = -1;

            // Frame
            req = connectedDevice.GetConfigPG(PdDeviceInfo.Configurations.Breaker_Frame).ReadRequest();
            res = await AsyncTransaction(req);
            if (res.goodResponse)
                connectedDevice.frame = res.Values[0];
            else
                connectedDevice.frame = "?";

            // Style
            string styleString = "PXR";
            req = connectedDevice.stylePG.ReadRequest();
            res = await AsyncTransaction(req);
            if (res.goodResponse)
            {
                if (res.KeyedValues["LCD Select"] == "1") styleString += "25";
                else styleString += "20";

                connectedDevice.ShortStyle = styleString;

                if (res.KeyedValues["Motor"] == "1") styleString += " MP";
                connectedDevice.StyleString = styleString;

                connectedDevice.StyleIndex = -1; // not used for PDs
            }
            else
            {
                connectedDevice.StyleString = "?";
                connectedDevice.ShortStyle = "?";
                connectedDevice.StyleIndex = -1;
            }

            UpdateConnectedDeviceInfo();
        }

        private async Task InitalReads_ACB()
        {
            // Rating
            EtuRequest req = connectedDevice.GetTestAndCalPG(TokyoDeviceInfo.TestAndCal.BreakerRating_Read).ReadRequest();
            EtuResponse res = await AsyncTransaction(req);
            if (res.goodResponse)
                connectedDevice.Rating = res.IntValues[0];
            else
                connectedDevice.Rating = -1;

            // Style
            req = connectedDevice.GetTestAndCalPG(TokyoDeviceInfo.TestAndCal.ETU_Style_Read).ActionCheckRequest();
            res = await AsyncTransaction(req);

            if (res.goodResponse)
            {
                connectedDevice.StyleString = res.Values[0];
                connectedDevice.ShortStyle = connectedDevice.StyleString.Substring(0, 5);
                connectedDevice.StyleIndex = int.Parse(res.RawValues[0]);
            }
            else
            {
                connectedDevice.StyleString = "?";
                connectedDevice.ShortStyle = "?";
                connectedDevice.StyleIndex = -1;
            }


            // Frame
            req = connectedDevice.GetTestAndCalPG(TokyoDeviceInfo.TestAndCal.BreakerFrame_Read).ReadRequest();
            res = await AsyncTransaction(req);
            if (res.goodResponse)
                connectedDevice.frame = res.Values[0];
            else
                connectedDevice.frame = "?";

            UpdateConnectedDeviceInfo();
        }

        private async Task InitalReads_PXR35()
        {
            // Rating
            connectedDevice.Rating = 1;

            // Style

            connectedDevice.StyleString = "PXR35";
            connectedDevice.ShortStyle = "PXR35";
            connectedDevice.StyleIndex = 0x35;

            // Frame
            connectedDevice.frame = "Bkr Supreme";

            UpdateConnectedDeviceInfo();
            Console.WriteLine();
        }

        private void Device_DisconnectEvent()
        {

        }
        #endregion __Inital Reads and Connection Event__

        #region Transactions
        public async Task<EtuResponse> AsyncTransaction(EtuRequest request)
        {
            if (device == null) return EtuResponse.FromNoConnection(request);
            if (!device.IsConnected) return EtuResponse.FromNoConnection(request);

            return await device.AsyncTransaction(request);
        }

        private async void inputPasswordButton_Click(object sender, EventArgs e)
        {
            inputPasswordButton.WorkStart();
            string passwordString = passwordTextbox.Text.PadLeft(4, '0');
            string[] writeValues = new string[]
            {
                passwordString.Substring(0),
                passwordString.Substring(1),
                passwordString.Substring(2),
                passwordString.Substring(3),
            };

            EtuResponse response = await AsyncTransaction(connectedDevice.remoteControlDict[14].ActionCheckRequest(writeValues, false));

            inputPasswordButton.ParseBool(response.goodResponse);
        }
        #endregion __Transactions__

        #region Form Loading and Closing
        private void MainForm_Load(object sender, EventArgs e)                      /// ON START
        {
            List<ComDevice> cds = connMenu.portChecker.CheckComPorts();
            connMenu.selectedPortFrame.UpdateComPortList(cds);

            if (!Directory.Exists("Config"))
                return;

            string fileText = "";
            if (File.Exists(RestoreInfoPath))
            {
                fileText = File.ReadAllText(RestoreInfoPath);
                RestoreInfo ri = JsonConvert.DeserializeObject<RestoreInfo>(fileText);

                autoConnectCheckbox.Checked = ri.AutoConnect;
                connMenu.AutoConnect = autoConnectCheckbox.Checked;

                if (ri.LastDevice != null) // Check for last device first. If found the select it. 
                {
                    bool wasFound = connMenu.selectedPortFrame.SelectRowIfMatched(ri.LastDevice);
                    if (wasFound)
                    {
                        connMenu.selectedPortFrame.UpdateSelectedDevice(ri.LastDevice);
                        if (ri.AutoConnect)
                            connMenu.Connect();
                    }
                }

                if (!connMenu.IsConnected && ri.AutoConnect)
                {
                    bool anyDevice = connMenu.selectedPortFrame.SelectFirst();
                    if (anyDevice)
                        connMenu.Connect();
                }
            }

            byteParseRTB_TextChanged(null, null); // Have placeholder values in textbox as an example. this will cause DGV to populate. 
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)    /// ON CLOSING
        {
            /// Check if Config directory exists. Create if not
            /// 
            if (!Directory.Exists("Config"))
            {
                Directory.CreateDirectory("Config");
            }

            RestoreInfo ri = new RestoreInfo()
            {
                LastDevice = connMenu.selectedPortFrame.SelectedComDevice,
                TabSelected = mainTabControl.SelectedTab.Name,
                AutoConnect = autoConnectCheckbox.Checked,
            };

            string rText = JsonConvert.SerializeObject(ri);
            File.WriteAllText(RestoreInfoPath, rText);
        }
        #endregion __Form Loading and Closing__

        #region Com Port Selection
        private void selectPortConnectFrame_RowClickedEvent(object sender, StasaLibrary.SelectConnection.RowClickedEventArgs e)
        {
            ChangeBroadDeviceType(e.comDevice.deviceType);
        }

        public void ChangeBroadDeviceType(ComDevice.BroadDeviceType newType)
        {
            switch (newType)
            {
                case ComDevice.BroadDeviceType.ACB:
                    Program.ChangeDeviceType(DeviceDiscovery.DeviceType.Tokyo);
                    break;
                case ComDevice.BroadDeviceType.PD:
                    Program.ChangeDeviceType(DeviceDiscovery.DeviceType.PdPxr25);
                    break;
                default:
                    Program.ChangeDeviceType(DeviceDiscovery.DeviceType.Pxr35);
                    break;

            }

            // Contols can subscribe to Program.DeviceChangedEvent to update on change. 
        }
        #endregion __Com Port Selections

        private void autoConnectCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            connMenu.AutoConnect = autoConnectCheckbox.Checked;
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comsLog.ClearAll();
        }

        private void byteParseRTB_TextChanged(object sender, EventArgs e)
        {
            string boxText = byteParseRTB.Text.Trim();

            string[] stringBytes = boxText.Split(' ');

            byteParseDGV.Rows.Clear();

            int messageLength = stringBytes.Length;

            bool isFullMessage = stringBytes[0] == "80" && stringBytes[messageLength - 1] == "FD";

            foreach (string b in stringBytes)
            {
                if (string.IsNullOrEmpty(b)) continue;

                int rowIndex = byteParseDGV.Rows.Add();

                int intVal = -1;
                try
                {
                    intVal = Convert.ToInt32(b, 16);
                }
                catch
                {

                }


                byteParseDGV.Rows[rowIndex].Cells[0].Value = rowIndex;
                byteParseDGV.Rows[rowIndex].Cells[1].Value = $"0x{b}";
                byteParseDGV.Rows[rowIndex].Cells[2].Value = intVal;

                if (isFullMessage)
                {
                    bool isResponse = false;

                    if (rowIndex == 0)
                        byteParseDGV.Rows[rowIndex].Cells[3].Value = "Start of Packet";
                    else if (rowIndex == 1)
                    {
                        if (intVal == 0) byteParseDGV.Rows[rowIndex].Cells[3].Value = "Read";
                        else if (intVal == 2) byteParseDGV.Rows[rowIndex].Cells[3].Value = "Write";
                        else if (intVal == 4) byteParseDGV.Rows[rowIndex].Cells[3].Value = "Action Check";
                        else isResponse = true;
                    }
                    else if (rowIndex == 4 && isResponse)
                        byteParseDGV.Rows[rowIndex].Cells[3].Value = EtuDevice.GetCorrectnessCodeString(intVal);
                    else if (rowIndex == messageLength - 3)
                        byteParseDGV.Rows[rowIndex].Cells[3].Value = "Checksum 1";
                    else if (rowIndex == messageLength - 2)
                        byteParseDGV.Rows[rowIndex].Cells[3].Value = "Checksum 2";
                    else if (rowIndex == messageLength - 1)
                        byteParseDGV.Rows[rowIndex].Cells[3].Value = "End of Package Designator";
                }
            }
        }

        private async void toggleManMoButton_Click(object sender, EventArgs e)
        {
            if (_isInManMo)
            {
                EtuRequest request = ExitManMoPg.ActionCheckRequest();
                EtuResponse response = await AsyncTransaction(request);

                if (response.goodResponse)
                {
                    _isInManMo = false;
                    toggleManMoButton.Text = "Enter Manufacturing Mode";
                    toggleManMoButton.BackColor = Color.LightSeaGreen;
                    toggleManMoButton.ForeColor = Color.Black;
                }
            }
            else
            {
                EtuRequest request = EnterManMoPG.ActionCheckRequest();
                EtuResponse response = await AsyncTransaction(request);

                if (response.goodResponse)
                {
                    _isInManMo = true;
                    toggleManMoButton.Text = "Exit Manufacturing Mode";
                    toggleManMoButton.BackColor = Color.ForestGreen;
                    toggleManMoButton.ForeColor = Color.Wheat;
                }
            }
        }

    }

}
