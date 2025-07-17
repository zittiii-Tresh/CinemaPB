using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CinemaPB.Forms
{
    public partial class StaffForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StaffForm()
        {
            InitializeComponent();
            staffLBL.Text = UserSession.Username; 
        }

        private void showtimehall1BTN_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new Hall1Showing());
        }

    }
}