using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PXR_Tool
{
    static class Program
    {
        public static string PdPxr25Path = @"S:\Stasa\Scripts\Blueberry\PdPxr25DeviceInfo.txt";
        public static string TokyoPath = @"S:\Stasa\Scripts\Blueberry\TokyoDeviceInfo.txt";
        public static string Pxr35Path = @"S:\Stasa\Scripts\Blueberry\Pxr35DeviceInfo.txt";

        public static StasaLibrary.DeviceInfo connectedDevice = null;

        public static event Action<BroadDeviceChangedEventArgs> DeviceChangedEvent;
        public static BroadDeviceType currentBDT = BroadDeviceType.None;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ChangeDeviceType(BroadDeviceType.Tokyo);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void ChangeDeviceType(BroadDeviceType newType)
        {
            BroadDeviceType oldType = currentBDT;
            if (newType == currentBDT) // Do nothing if type changes.
                return;


            string parseText;
            switch (newType)
            {
                case BroadDeviceType.Tokyo:
                    parseText = System.IO.File.ReadAllText(TokyoPath);
                    connectedDevice = Newtonsoft.Json.JsonConvert.DeserializeObject<StasaLibrary.TokyoDeviceInfo>(parseText);
                    break;
                case BroadDeviceType.PdPxr25:
                    parseText = System.IO.File.ReadAllText(PdPxr25Path);
                    connectedDevice = Newtonsoft.Json.JsonConvert.DeserializeObject<StasaLibrary.PdDeviceInfo>(parseText);
                    break;
                default:
                    parseText = System.IO.File.ReadAllText(Pxr35Path);
                    connectedDevice = Newtonsoft.Json.JsonConvert.DeserializeObject<StasaLibrary.DeviceInfo>(parseText);
                    break;
            }

            currentBDT = newType;

            if (oldType == BroadDeviceType.None)
                return;

            BroadDeviceChangedEventArgs bdcea = new BroadDeviceChangedEventArgs() { newType = newType, previousType = oldType };
            DeviceChangedEvent?.Invoke(bdcea);
        }
    }

    public class BroadDeviceChangedEventArgs : EventArgs
    {
        public BroadDeviceType previousType { get; set; }
        public BroadDeviceType newType { get; set; }
    }
}
