
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PXR_Tool
{
    static class Program
    {
        public static StasaLibrary.DeviceInfo connectedDevice = null;

        public static event Action<BroadDeviceChangedEventArgs> DeviceChangedEvent;
        public static DeviceType currentBDT = DeviceType.None;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ChangeDeviceType(DeviceType.Pxr35);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void ChangeDeviceType(DeviceType newType)
        {
            DeviceType oldType = currentBDT;
            if (newType == currentBDT) // Do nothing if type changes.
                return;


            string parseText;
            switch (newType)
            {
                case DeviceType.Tokyo:
                    connectedDevice = Newtonsoft.Json.JsonConvert.DeserializeObject<StasaLibrary.TokyoDeviceInfo>(Properties.Resources.TokyoDeviceInfo);
                    break;
                case DeviceType.PdPxr25:
                    connectedDevice = Newtonsoft.Json.JsonConvert.DeserializeObject<StasaLibrary.PdDeviceInfo>(Properties.Resources.PdPxr25DeviceInfo);
                    break;
                default:
                    connectedDevice = Newtonsoft.Json.JsonConvert.DeserializeObject<StasaLibrary.Pxr35DeviceInfo>(Properties.Resources.Pxr35DeviceInfo);
                    break;
            }

            currentBDT = newType;

            if (oldType == DeviceType.None)
                return;

            BroadDeviceChangedEventArgs bdcea = new BroadDeviceChangedEventArgs() { newType = newType, previousType = oldType };
            DeviceChangedEvent?.Invoke(bdcea);
        }
    }

    public class BroadDeviceChangedEventArgs : EventArgs
    {
        public DeviceType previousType { get; set; }
        public DeviceType newType { get; set; }
    }
}
