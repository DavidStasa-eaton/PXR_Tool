using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXR_Tool.RemoteControl
{
    interface IRemoteControl
    {
        void InitButtons();
        StasaLibrary.DeviceInfo deviceInfo { get; set; }
    }
}
