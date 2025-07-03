using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CinemaPB.Forms;
using DevExpress.Utils;

namespace CinemaPB
{
    public partial class Login : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Login()
        {
            InitializeComponent();
            ApplyTextEditBehaviors();
        }

        private void SignUphlbl_Click(object sender, EventArgs e)
        {
            FormHelper.SwitchForm(this, new SignUpForm());
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            FormHelper.SwitchForm(this, new MainForm());
        }
        private void ApplyTextEditBehaviors()
        {
            TextHideShowHelper.AttachBehavior(usernameTE, "Username");
            TextHideShowHelper.AttachBehavior(passwordTE, "Password", true);
        }
    }
}
