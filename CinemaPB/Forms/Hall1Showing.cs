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
    public partial class Hall1Showing : DevExpress.XtraEditors.XtraUserControl
    {
        public Hall1Showing()
        {
            InitializeComponent();
            dateLBL.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm tt");

        }

        private void winExplorerView1_HtmlElementMouseClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewHtmlElementEventArgs e)
        {
            

        }
    }
}
