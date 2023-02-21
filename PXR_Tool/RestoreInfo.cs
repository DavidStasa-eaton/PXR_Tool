using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StasaLibrary;


namespace PXR_Tool
{
    public class RestoreInfo
    {
        public ComDevice LastDevice { get; set; }
        public string TabSelected { get; set; }
        public string SubTabSelected { get; set; }
        public bool AutoConnect { get; set; }
    }
}
