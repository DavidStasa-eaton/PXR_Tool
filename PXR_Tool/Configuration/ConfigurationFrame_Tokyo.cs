using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StasaLibrary;

namespace PXR_Tool.Configuration
{
    public partial class ConfigurationFrame_Tokyo : UserControl, IDeviceControlFrame
    {
        public DeviceInfo deviceInfo { get; set; } = DeviceDiscovery.GetDevice(DeviceDiscovery.DeviceType.Tokyo);

        public ConfigurationFrame_Tokyo()
        {
            InitializeComponent();

            etuStyleFrame.dropDownMenu.Items.AddRange(TokyoDeviceInfo.styleArray);
            breakerRatingFrame.dropDownMenu.Items.AddRange(new string[] {"100", "200","250","300","400","500","600","630","800",
                "1000","1200","1250","1600","2000","2500","3000","3200","3600","3800","4000","5000","6000","6300"});
        }

        public void InitButtons()
        {
            foreach (Control c in etuGroupBox.Controls)
            {
                ((StasaLibrary.DataFrames.IDeviceControlFrame)c).BindDevice(MainForm.instance.device);
            }
            foreach (Control c in breakerGroupBox.Controls)
            {
                ((StasaLibrary.DataFrames.IDeviceControlFrame)c).BindDevice(MainForm.instance.device);
            }

            etuStyleFrame.paramGroup = deviceInfo.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.ETU_Style_Read];
            etuStyleFrame.writeParamGroup = deviceInfo.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.ETU_Style_Write];
            etuStyleFrame.preWriteDel = (string value) =>
            {
                return TokyoDeviceInfo.GetStyleWriteIndex(etuStyleFrame.dropDownMenu.Text).ToString();
            };

            breakerRatingFrame.paramGroup = deviceInfo.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.BreakerRating_Read];
            breakerRatingFrame.writeParamGroup = deviceInfo.testAndCalDict[(int)TokyoDeviceInfo.TestAndCal.BreakerRating_Write];
        }
    }
}
