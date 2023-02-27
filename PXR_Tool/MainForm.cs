using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            //LoadInfo_PDPXR25();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            connMenu.WindowsMessage(ref m);
        }

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

        public async Task<EtuResponse> AsyncTransaction(EtuRequest request)
        {
            if (device == null) return EtuResponse.FromNoConnection(request);
            if (!device.IsConnected) return EtuResponse.FromNoConnection(request);

            return await device.AsyncTransaction(request);
        }

        public void ChangeDeviceType(ComDevice.BroadDeviceType newType)
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
        }

        private void selectPortConnectFrame_RowClickedEvent(object sender, StasaLibrary.SelectConnection.RowClickedEventArgs e)
        {
            ChangeDeviceType(e.comDevice.deviceType);
        }

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

        private void Handle_PortStateChange(PortStateChangeArgs psca)
        {

            connMenu.selectedPortFrame.UpdateComPortList(psca.comDevicesFound);
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

        private void autoConnectCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            connMenu.AutoConnect = autoConnectCheckbox.Checked;
        }
    }

    

}
