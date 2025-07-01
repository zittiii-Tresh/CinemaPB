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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void moviesACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new MoviesForm());
        }

        private void employeelistACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new EmployeeListForm());
        }
    }
}