using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CinemaPB.Forms
{
    public class TextHideShowHelper
    {
        public static void AttachBehavior(TextEdit textEdit, string defaultText, bool isPassword = false)
        {
            textEdit.Text = defaultText;
            textEdit.ForeColor = Color.DarkGray;
            textEdit.Properties.UseSystemPasswordChar = false;

            textEdit.Enter += (s, e) =>
            {
                if (textEdit.Text == defaultText)
                {
                    textEdit.Text = "";
                    textEdit.ForeColor = Color.Black;

                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = true;
                }
            };

            textEdit.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textEdit.Text))
                {
                    textEdit.Text = defaultText;
                    textEdit.ForeColor = Color.DarkGray;
                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = false;
                }
            };

            textEdit.EditValueChanged += (s, e) =>
            {
                if (textEdit.Text != defaultText)
                {
                    textEdit.ForeColor = Color.Black;
                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = true;
                }
            };
        }
    }
}
