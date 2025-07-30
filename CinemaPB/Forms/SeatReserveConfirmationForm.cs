using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaPB.Forms
{
    public partial class SeatReserveConfirmationForm : DevExpress.XtraEditors.XtraForm
    {
        public string EnteredUsername { get; private set; }
        private readonly string expectedUsername;
        public string ReservedUsername => usernameTE.Text.Trim();

        public SeatReserveConfirmationForm(string reservedName)
        {
            InitializeComponent();
            expectedUsername = reservedName;
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            if (usernameTE.Text.Trim().Equals(expectedUsername, StringComparison.OrdinalIgnoreCase))
            {
                EnteredUsername = usernameTE.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Incorrect username. Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}