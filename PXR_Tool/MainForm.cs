using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Newtonsoft.Json;

using StasaLibrary;

namespace PXR_Tool
{
    public enum BroadDeviceType { PdPxr25, PdPxr20, Tokyo, Acb20, Acb22, Pxr35, None }

    public partial class MainForm : Form
    {
        public static MainForm instance;

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
            selectPortConnectFrame.BindDevice(device);
            device.ConnectedEvent += Device_ConnectedEvent;
            device.DisconnectEvent += Device_DisconnectEvent;

            selectPortConnectFrame.portChecker.PortStateChanged += Handle_PortStateChange;

            //LoadInfo_PDPXR25();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            selectPortConnectFrame.WindowsMessage(ref m);
        }

        private async void Device_ConnectedEvent(ConnectionEventArgs obj)
        {
            switch (selectPortConnectFrame.SelectedPortFrame.SelectedComDevice.deviceType)
            {
                case ComDevice.DeviceType.PD:
                    //LoadInfo_PDPXR25();
                    await InitalReads_PD();
                    break;
                case ComDevice.DeviceType.ACB:
                    await InitalReads_ACB();
                    break;
                case ComDevice.DeviceType.Mod:
                    break;
                case ComDevice.DeviceType.Other:
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
            UniRequest req = connectedDevice.GetConfigPG(PdDeviceInfo.Configurations.Breaker_Rating).ReadRequest();
            UniResponse res = await AsyncTransaction(req);
            connectedDevice.Rating = res.IntValues[0];

            // Frame
            req = connectedDevice.GetConfigPG(PdDeviceInfo.Configurations.Breaker_Frame).ReadRequest();
            res = await AsyncTransaction(req);
            connectedDevice.frame = res.Values[0];

            // Style
            string styleString = "PXR";
            req = connectedDevice.stylePG.ReadRequest();
            res = await AsyncTransaction(req);
            if (res.KeyedValues["LCD Select"] == "1") styleString += "25";
            else styleString += "20";

            connectedDevice.ShortStyle = styleString;

            if (res.KeyedValues["Motor"] == "1") styleString += " MP";
            connectedDevice.StyleString = styleString;

            //connectedDevice.frame = res.Values[0];

            //LoadInfo_PDPXR25();

            UpdateConnectedDeviceInfo();
        }

        private async Task InitalReads_ACB()
        {
            // Rating
            UniRequest req = connectedDevice.GetTestAndCalPG(TokyoDeviceInfo.TestAndCal.BreakerRating_Read).ReadRequest();
            UniResponse res = await AsyncTransaction(req);
            connectedDevice.Rating = res.IntValues[0];

            // Style
            req = connectedDevice.GetTestAndCalPG(TokyoDeviceInfo.TestAndCal.ETU_Style_Read).ActionCheckRequest();
            res = await AsyncTransaction(req);
            
            connectedDevice.StyleString = res.Values[0];
            connectedDevice.ShortStyle = connectedDevice.StyleString.Substring(0, 5);
            connectedDevice.StyleIndex = int.Parse(res.RawValues[0]);

            // Frame
            req = connectedDevice.GetTestAndCalPG(TokyoDeviceInfo.TestAndCal.BreakerFrame_Read).ReadRequest();
            res = await AsyncTransaction(req);
            connectedDevice.frame = res.Values[0];

            UpdateConnectedDeviceInfo();
            Console.WriteLine();
        }

        private void Device_DisconnectEvent()
        {
            
        }

        public async Task<UniResponse> AsyncTransaction(UniRequest request)
        {
            if (device == null) return UniResponse.FromNoConnection(request);
            if (!device.IsConnected) return UniResponse.FromNoConnection(request);

            return await device.AsyncTransaction(request);
        }

        public void ChangeDeviceType(ComDevice.DeviceType newType)
        {
            switch (newType)
            {
                case ComDevice.DeviceType.ACB:
                    Program.ChangeDeviceType(BroadDeviceType.Tokyo);
                    break;
                case ComDevice.DeviceType.PD:
                    Program.ChangeDeviceType(BroadDeviceType.PdPxr25);
                    break;
                default:
                    Program.ChangeDeviceType(BroadDeviceType.Pxr35);
                    break;

            }
        }

        private void selectPortConnectFrame_RowClickedEvent(object sender, StasaLibrary.SelectConnection.RowClickedEventArgs e)
        {
            ChangeDeviceType(e.comDevice.deviceType);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<ComDevice> cds = selectPortConnectFrame.portChecker.CheckComPorts();
            selectPortConnectFrame.selectedPortFrame.UpdateComPortList(cds);
        }

        private void Handle_PortStateChange(PortStateChangeArgs psca)
        {
            if (!psca.PortWasAdded && device.IsConnected)
            {
                //if (pselectPortConnectFrame.SelectedComPort)
            }

            selectPortConnectFrame.selectedPortFrame.UpdateComPortList(psca.comDevicesFound);
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

            UniResponse response = await AsyncTransaction(connectedDevice.remoteControlDict[14].ActionCheckRequest(writeValues, false));

            inputPasswordButton.ParseBool(response.goodResponse);
        }
    }

    

}
