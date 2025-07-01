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
using CinemaPB.Forms;

namespace CinemaPB.Forms
{
    public partial class EmployeeListForm : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void addemployeeBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new SignUpForm());
        }
    }
}
