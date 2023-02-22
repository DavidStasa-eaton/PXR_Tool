
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StasaLibrary;

namespace PXR_Tool
{
    static class Program
    {
        public static StasaLibrary.DeviceInfo connectedDevice = null;

        public static event Action<BroadDeviceChangedEventArgs> DeviceChangedEvent;
        public static DeviceDiscovery.DeviceType currentBDT = DeviceDiscovery.DeviceType.None;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ChangeDeviceType(DeviceDiscovery.DeviceType.Pxr35);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void ChangeDeviceType(DeviceDiscovery.DeviceType newType)
        {
            DeviceDiscovery.DeviceType oldType = currentBDT;
            if (newType == currentBDT) // Do nothing if type changes.
                return;


            connectedDevice = DeviceDiscovery.GetDevice(newType);

            currentBDT = newType;

            if (oldType == DeviceDiscovery.DeviceType.None)
                return;

            BroadDeviceChangedEventArgs bdcea = new BroadDeviceChangedEventArgs() { newType = newType, previousType = oldType };
            DeviceChangedEvent?.Invoke(bdcea);
        }
    }

    public class BroadDeviceChangedEventArgs : EventArgs
    {
        public DeviceDiscovery.DeviceType previousType { get; set; }
        public DeviceDiscovery.DeviceType newType { get; set; }
    }
}
