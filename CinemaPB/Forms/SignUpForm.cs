using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaPB.Employees;
using Dapper;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker.Parser;

namespace CinemaPB.Forms
{
    public partial class SignUpForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SignUpForm()
        {
            InitializeComponent();
            ApplyTextEditBehaviors();
            passwordBE.Tag = "eyeopen";
            passwordBE.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
        }

        private void ApplyTextEditBehaviors()
        {
            TextHideShowHelper.AttachBehavior(firstnameTE, "Firstname");
            TextHideShowHelper.AttachBehavior(middlenameTE, "Middlename");
            TextHideShowHelper.AttachBehavior(lastnameTE, "Lastname");
            TextHideShowHelper.AttachBehavior(extensionTE, "Extension");
            TextHideShowHelper.AttachBehavior(contactnoTE, "Contact no.");
            TextHideShowHelper.AttachBehavior(addressTE, "Address");
            TextHideShowHelper.AttachBehavior(usernameTE, "Username");
            TextHideShowHelper.AttachBehavior(passwordBE, "Password", true);
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void passwordTE_ButtonPressed_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
        private void passwordTE_EditValueChanged(object sender, EventArgs e)
        {
            string password = passwordBE.Text;
            string message = "";

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
        private static void RegisterAccount(Employees.Employee employee)
        {
            using (var connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                var query = GlobalSQL.SQLQuery.InsertAccount;
                int rowsAffected = connection.Execute(query, employee);
            }
        }
        private bool UsernameExists(string username)
        {
            using (var connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Employees WHERE Username = @Username";
                int count = connection.ExecuteScalar<int>(query, new { Username = username });
                return count > 0;
            }
        }

        private void signupBTN_Click(object sender, EventArgs e)
        {
            var confirmResult = XtraMessageBox.Show("Do you want to save this account?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
                return;

            string username = usernameTE.Text.Trim();

            if (UsernameExists(username))
            {
                XtraMessageBox.Show("Username already exists!", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roleID = Convert.ToInt32(positionRG.EditValue);       
            string gender = genderRG.EditValue?.ToString();

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordBE.Text);

            var employee = new Employees.Employee
            {
                FirstName = firstnameTE.Text,
                MiddleName = middlenameTE.Text,
                LastName = lastnameTE.Text,
                NameExtension = extensionTE.Text,
                ContactNo = contactnoTE.Text,
                Address = addressTE.Text,
                Username = username,
                Password = hashedPassword,
                StatusID = 0,
                EmploymentStatus = 1,
                RoleID = roleID,
                Gender = gender 
            };

            RegisterAccount(employee);

            XtraMessageBox.Show("Account saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}