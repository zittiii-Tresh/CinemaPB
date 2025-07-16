using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CinemaPB.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace CinemaPB
{
    public partial class Login : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Login()
        {
            InitializeComponent();
            ApplyTextEditBehaviors();
        }

        private void SignUphlbl_Click(object sender, EventArgs e)
        {
            FormHelper.SwitchForm(this, new SignUpForm());
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string username = usernameTE.Text.Trim();
            string password = passwordTE.Text;

            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                string query = @"
                                SELECT Password, RoleID, FailedAttempts, IsLocked
                                FROM emp.Employees
                                WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashedPassword = reader["Password"].ToString();
                        int roleID = Convert.ToInt32(reader["RoleID"]);
                        int failedAttempts = reader.IsDBNull(reader.GetOrdinal("FailedAttempts")) ? 0 : Convert.ToInt32(reader["FailedAttempts"]);
                        bool isLocked = reader.IsDBNull(reader.GetOrdinal("IsLocked")) ? false : Convert.ToBoolean(reader["IsLocked"]);
                        reader.Close(); // Close before new SQL command

                        if (isLocked)
                        {
                            MessageBox.Show("Your account is locked. Please contact the administrator.");
                            return;
                        }

                        if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                        {
                            // Successful login: reset FailedAttempts to 0
                            string resetQuery = @"
                                                    UPDATE emp.Employees 
                                                    SET FailedAttempts = 0 
                                                    WHERE Username = @username";

                            using (SqlCommand resetCmd = new SqlCommand(resetQuery, connection))
                            {
                                resetCmd.Parameters.AddWithValue("@username", username);
                                resetCmd.ExecuteNonQuery();
                            }

                            this.Hide();
                            if (roleID == 1)
                            {
                                MainForm adminForm = new MainForm();
                                adminForm.ShowDialog();
                            }
                            else if (roleID == 2)
                            {
                                StaffForm staffForm = new StaffForm();
                                staffForm.ShowDialog();
                            }
                            this.Show();
                        }
                        else
                        {
                            // Increment failed attempts
                            failedAttempts++;
                            bool shouldLock = failedAttempts >= 5;

                            string updateQuery = @"
                                                    UPDATE emp.Employees 
                                                    SET FailedAttempts = @failed, IsLocked = @locked 
                                                    WHERE Username = @username";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@failed", failedAttempts);
                                updateCmd.Parameters.AddWithValue("@locked", shouldLock);
                                updateCmd.Parameters.AddWithValue("@username", username);
                                updateCmd.ExecuteNonQuery();
                            }

                            if (shouldLock)
                            {
                                MessageBox.Show("Account locked after 5 failed login attempts.");
                            }
                            else if (failedAttempts == 4)
                            {
                                MessageBox.Show("Invalid password. You have 1 attempt left before your account will be locked.");
                            }
                            else
                            {
                                MessageBox.Show($"Invalid password. Attempt {failedAttempts} of 5.");
                            }
                        }
                    }
                }
            }
        }

        private void ApplyTextEditBehaviors()
        {
            TextHideShowHelper.AttachBehavior(usernameTE, "Username");
            TextHideShowHelper.AttachBehavior(passwordTE, "Password", true);
        }

        private void showCE_CheckedChanged(object sender, EventArgs e)
        {
            passwordTE.Properties.UseSystemPasswordChar = !showCE.Checked;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
