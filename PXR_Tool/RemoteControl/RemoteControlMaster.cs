﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StasaLibrary;

namespace PXR_Tool.RemoteControl
{
    public partial class RemoteControlMaster : UserControl
    {
        private Control _packControl;
        private DeviceDiscovery.DeviceType _currentType = DeviceDiscovery.DeviceType.None;

        public RemoteControlMaster()
        {
            InitializeComponent();

            Program.DeviceChangedEvent += Program_DeviceChangedEvent;
        }

        private void Program_DeviceChangedEvent(BroadDeviceChangedEventArgs obj)
        {
            BindDeviceType(Program.currentBDT);
        }

        public void BindDeviceType(DeviceDiscovery.DeviceType dt)
        {
            if (_currentType == dt) return;

            _currentType = dt;
            UnpackCurrentControl();
            switch (dt)
            {
                case DeviceDiscovery.DeviceType.PdPxr25:
                case DeviceDiscovery.DeviceType.PdPxr20:
                    _packControl = new RemoteControl_PD();
                    break;
            }

            InitPackedControl();

        }

        private void UnpackCurrentControl()
        {
            if (_packControl == null)
                return;

            Controls.Remove(_packControl);
            _packControl = null;
        }

        private void InitPackedControl()
        {
            if (_packControl == null) return;

            _packControl.Dock = DockStyle.Fill;
            ((IRemoteControl)_packControl).InitButtons();
            Controls.Add(_packControl);

        }
    }
}
