using System;
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
        }
        public static void DisplayForm(Form targetForm, Action onCloseCallback)
        {
            targetForm.FormClosed += (s, e) => onCloseCallback?.Invoke();
            targetForm.Show();
        }
        public static void DisplayForm(Form targetForm)
        {
            targetForm.Show(); // Non-blocking, no callback
        }
        public static void LoadUserControl(SidePanel targetPanel, UserControl controlToLoad)
        {
            targetPanel.Controls.Clear();
            controlToLoad.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(controlToLoad);
        }
    }
}