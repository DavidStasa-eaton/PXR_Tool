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

namespace PXR_Tool
{
    public partial class ParameterGroupFrame : UserControl
    {
        public event EventHandler<PostTransactionEventArgs> PostReadEvent;
        public event EventHandler<PostTransactionEventArgs> PostWriteEvent;

        protected bool _isInDesignMode = false;

        private Point _subControlLocation = new Point(3, 48);
        public Point SubControlLocation { get { return _subControlLocation; }
            set
            {
                _subControlLocation = value;
            }
        }

        protected event EventHandler<SizeChangeEventArgs> SizeAltered;

        private byte _bufferByte;
        public byte BufferByte { get { return _bufferByte; }
            set
            {
                _bufferByte = value;
                groupBox.Text = $"Group {value}";
                UpdateParmeterGroup();
            }
        }

        protected ParameterGroup _pGroup;

        private bool _isReadOnly = false;
        public bool IsReadOnly { get { return _isReadOnly; }
            set
            {
                _isReadOnly = true;
                ToggleReadOnly();
            }
        }

        public ParameterGroupFrame()
        {
            InitializeComponent();
        }

        protected void CheckIfDesignMode()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                _isInDesignMode = true; ;
            }
        }

        protected void ToggleReadOnly()
        {
            writeButton.Visible = !_isReadOnly;
        }

        // will set a flag when all properties are set to allow for packing of controls.
        public virtual bool CheckForFullyInit()
        {
            return true;
        }

        /// <summary>
        /// Must be overriden.
        /// Child class should check if ParameterGroup for specified critieria exists and then populate the frame with controls.
        /// </summary>
        public virtual void UpdateParmeterGroup()
        {
            

        }

        /// <summary>
        /// Will return connected device if one exist. Will return PXR35 Device if in design mode. 
        /// Will Disable control if null is returned.
        /// </summary>
        /// <returns></returns>
        protected DeviceInfo GetDeviceInfo(bool designMode = false)
        {
            Enabled = true;
            if (Program.connectedDevice == null)
            {
                if (designMode)
                {
                    Enabled = true;
                    return DeviceDiscovery.GetDevice(DeviceDiscovery.DeviceType.Pxr35);
                }
            }
            else
            {
                Enabled = true;
                return Program.connectedDevice;
            }

            Enabled = false;
            return null;
        }

        private void ParameterGroupFrame_Load(object sender, EventArgs e)
        {
            
            UpdateParmeterGroup();
            
        }

        private void ParameterGroupFrame_SizeChanged(object sender, EventArgs e)
        {
            SizeChangeEventArgs scea = new SizeChangeEventArgs() { x = _subControlLocation.X, y = _subControlLocation.Y };

            scea.width = groupBox.Width - 5;
            scea.height = groupBox.Height - (scea.y + 5);

            SizeAltered?.Invoke(this, scea);
        }

        protected void AutoHeight(Control subControl)
        {
            SizeChangeEventArgs scea = new SizeChangeEventArgs() { x = _subControlLocation.X, y = _subControlLocation.Y };

            Size = new Size(Size.Width, subControl.Height + scea.y + 5);
        }

        protected void AutoHeight(int subHeight)
        {
            SizeChangeEventArgs scea = new SizeChangeEventArgs();

            Size = new Size(Size.Width, subHeight + scea.y + 5);
        }
    
        protected void AdjustSize(int width, int height)
        {
            Size = new Size(width, height);

            writeButton.Location = new Point(Size.Width - (writeButton.Size.Width + 20), writeButton.Location.Y);
        }

        private void groupBox_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }

    public class PostTransactionEventArgs : EventArgs
    {
        public UniResponse response { get; set; }
    }

    public class SizeChangeEventArgs: EventArgs
    {
        public int x { get; set; } = 3;
        public int y { get; set; } = 48;
        public int height { get; set; } = 50;
        public int width { get; set; } = 100;
    }
}
