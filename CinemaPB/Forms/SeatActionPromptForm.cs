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
    public partial class SeatActionPromptForm : DevExpress.XtraEditors.XtraForm
    {
        public string SelectedAction { get; private set; }

        public SeatActionPromptForm(string seatName)
        {
            InitializeComponent();
            labelControl1.Text = $"What would you like to do with seat {seatName}?";
        }

        private void buyBTN_Click(object sender, EventArgs e)
        {
            SelectedAction = "Buy";
            this.DialogResult = DialogResult.OK;
        }

        private void reserveBTN_Click(object sender, EventArgs e)
        {
            SelectedAction = "Reserve";
            this.DialogResult = DialogResult.OK;
        }
    }
}