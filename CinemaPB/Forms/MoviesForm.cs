using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CinemaPB.Forms
{
    public partial class MoviesForm : DevExpress.XtraEditors.XtraUserControl
    {
        public MoviesForm()
        {
            InitializeComponent();
            SetupToggleSwitch();
        }
        private void SetupToggleSwitch()
        {
            toggleSwitch1.Properties.ValueOff = "Disabled";
            toggleSwitch1.Properties.ValueOn = "Enabled";
            var a = toggleSwitch1.Properties.GetValueByState(false); // returns "Disabled"
            var b = toggleSwitch1.Properties.GetStateByValue("Enabled"); // returns true
            var c = toggleSwitch1.Properties.GetStateByValue("Activated"); // returns false
        }
      
    }

}

