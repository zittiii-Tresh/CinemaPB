using System.Windows.Forms;
using CinemaPB.Forms;
using DevExpress.XtraEditors;

namespace CinemaPB
{
    public class FormHelper
    {
        public static void SwitchForm(Form currentForm, Form targetForm)
        {
            targetForm.Show();
            currentForm.Hide();
        }
        public static void LoadUserControl(SidePanel targetPanel, UserControl controlToLoad)
        {
            targetPanel.Controls.Clear();
            controlToLoad.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(controlToLoad);
        }
    }
}