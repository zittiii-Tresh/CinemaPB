using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CinemaPB.Forms
{
    public partial class ChangePasswordForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _username;
        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            _username = username;
            ApplyTextEditBehaviors();
            resultcaptionLBL.Visible = false;
            resultLBL.Visible = false;
            lblConfirmPasswordCaption.Visible = false;
        }

        private void ApplyTextEditBehaviors()
        {
            TextHideShowHelper.AttachBehavior(passwordBE, "Password", true);
            TextHideShowHelper.AttachBehavior(beConfirmPassword, "Password", true);
        }

        private void passwordBE_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = passwordBE.Tag?.ToString() ?? "eyeopen";

            if (tagAction == "eyeopen")
            {
                passwordBE.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                passwordBE.Tag = "eyeclose";
                passwordBE.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBE.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                passwordBE.Tag = "eyeopen";
                passwordBE.Properties.UseSystemPasswordChar = true;
            }
        }



        private void passwordBE_EditValueChanged(object sender, EventArgs e)
        {
            string password = passwordBE.Text;
            string message = "";

            if (string.IsNullOrWhiteSpace(password))
            {
                resultcaptionLBL.Visible = false;
                resultLBL.Visible = false;
                return;
            }

            resultcaptionLBL.Visible = true;
            resultLBL.Visible = true;

            if (password.Length < 8)
                message += " - Must be at least 8 characters long\n";
            if (!password.Any(char.IsUpper))
                message += " - Must contain at least one uppercase letter\n";
            if (!password.Any(char.IsLower))
                message += " - Must contain at least one lowercase letter\n";
            if (!password.Any(char.IsDigit))
                message += " - Must contain at least one number\n";
            if (!password.All(char.IsLetterOrDigit))
                message += " - Must not contain special characters\n";

            if (string.IsNullOrEmpty(message))
            {
                resultcaptionLBL.Text = "✅ Password is valid!";
                resultLBL.Text = message;
                resultcaptionLBL.ForeColor = Color.PaleGreen;
                resultLBL.ForeColor = Color.PaleGreen;
            }
            else
            {
                resultcaptionLBL.Text = "❌ Password is invalid";
                resultLBL.Text = message;
                resultcaptionLBL.ForeColor = Color.LightCoral;
                resultLBL.ForeColor = Color.LightCoral;
            }
        }

        private void beConfirmPassword_EditValueChanged(object sender, EventArgs e)
        {
            string password = passwordBE.Text;
            string confirmPassword = beConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblConfirmPasswordCaption.Visible = false;
                return;
            }

            lblConfirmPasswordCaption.Visible = true;

            if (password == confirmPassword)
            {
                lblConfirmPasswordCaption.Text = "✅  Password confirmed!";
                lblConfirmPasswordCaption.ForeColor = Color.PaleGreen;
            }
            else
            {
                lblConfirmPasswordCaption.Text = "❌  Password mismatch";
                lblConfirmPasswordCaption.ForeColor = Color.LightCoral;
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            string newPassword = passwordBE.Text;
            string confirmPassword = beConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Password validation (you already validate live too)
            if (newPassword.Length < 8 ||
                !newPassword.Any(char.IsUpper) ||
                !newPassword.Any(char.IsLower) ||
                !newPassword.Any(char.IsDigit) ||
                !newPassword.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Password does not meet the requirements.");
                return;
            }

            // Hash and update in DB
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

            using (SqlConnection conn = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                conn.Open();
                string query = "UPDATE emp.Employees SET Password = @password WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@username", _username); // use stored username

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        GlobalLogger.employeeLog("Edited employee password", _username);
                        MessageBox.Show("Password updated successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
            }
        }

        private void beConfirmPassword_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = beConfirmPassword.Tag?.ToString() ?? "eyeopen";

            if (tagAction == "eyeopen")
            {
                beConfirmPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                beConfirmPassword.Tag = "eyeclose";
                beConfirmPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                beConfirmPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                beConfirmPassword.Tag = "eyeopen";
                beConfirmPassword.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}