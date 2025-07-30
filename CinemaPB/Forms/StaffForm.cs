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

        private void showtimehall2BTN_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new Hall2Showing());
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                UserSession.Username = null;

                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();
            }
        }
    }
}