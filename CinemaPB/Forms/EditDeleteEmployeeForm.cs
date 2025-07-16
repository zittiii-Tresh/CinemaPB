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
using CinemaPB.Configuration;
using CinemaPB.Employees;
using CinemaPB.Infrastructure.Repositories;
using Dapper;
using DevExpress.XtraEditors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CinemaPB.Forms
{
    public partial class EditDeleteEmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        private string username;
        public EditDeleteEmployeeForm(string selectedUsername)
        {
            InitializeComponent();
            SetupToggleSwitch();
            ApplyTextEditBehaviors();
            username = selectedUsername;
            LoadEmployeeData();
            accountTS.Toggled += accountTS_Toggled; // 👈 Hook the event
            UpdateAvailabilityLabel();                      // 👈 Set initial state
        }

        private void SetupToggleSwitch()
        {
            accountTS.Properties.ValueOff = "Unlocked";
            accountTS.Properties.ValueOn = "Locked";
            var a = accountTS.Properties.GetValueByState(false); // returns "Disabled"
            var b = accountTS.Properties.GetStateByValue("Locked"); // returns true
            var c = accountTS.Properties.GetStateByValue("Unlocked"); // returns false
        }

        private void UpdateAvailabilityLabel()
        {
            if (accountTS.IsOn)
            {
                availabilityLC.Text = "Locked";
                availabilityLC.ForeColor = Color.Green;
            }
            else
            {
                availabilityLC.Text = "Unlocked";
                availabilityLC.ForeColor = Color.Red;
            }
        }

        private void accountTS_Toggled(object sender, EventArgs e)
        {
            UpdateAvailabilityLabel();
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
        }

        private void LoadEmployeeData()
        {
            using (var connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                string query = @"SELECT EmployeeID, RoleID, FirstName, MiddleName, LastName, NameExtension, Gender,
                                        ContactNo, Address, Username, EmploymentStatus, StatusID, IsLocked
                                 FROM emp.Employees
                                 WHERE Username = @Username";

                var employee = connection.QueryFirstOrDefault<dynamic>(query, new { Username = username });

                if (employee != null)
                {
                    firstnameTE.Text = employee.FirstName;
                    middlenameTE.Text = employee.MiddleName;
                    lastnameTE.Text = employee.LastName;
                    extensionTE.Text = employee.NameExtension;
                    contactnoTE.Text = employee.ContactNo;
                    addressTE.Text = employee.Address;
                    usernameTE.Text = employee.Username;

                    positionRG.SelectedIndex = Convert.ToInt32(employee.RoleID) - 1;

                    if (employee.Gender == "Male")
                        genderRG.SelectedIndex = 0;
                    else if (employee.Gender == "Female")
                        genderRG.SelectedIndex = 1;
                    else
                        genderRG.SelectedIndex = -1;

                    employeeRG.SelectedIndex = Convert.ToInt32(employee.EmploymentStatus) - 1;

                    // ✅ FIX: IsLocked cast
                    if (employee.IsLocked is bool boolVal)
                        accountTS.IsOn = boolVal;
                    else
                        accountTS.IsOn = employee.IsLocked.ToString() == "Locked" || employee.IsLocked.ToString() == "1";
                }
                else
                {
                    XtraMessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        public bool UpdateEmployee(Employees.Employee employee, string username)
        {
            using (var connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                string updateQuery = GlobalSQL.SQLQuery.UpdateAccount; 

                var parameters = new
                {
                    employee.RoleID,
                    employee.FirstName,
                    employee.MiddleName,
                    employee.LastName,
                    employee.NameExtension,
                    employee.ContactNo,
                    employee.Address,
                    employee.Username,
                    employee.EmploymentStatus,
                    employee.StatusID,
                    employee.IsLocked,
                    OriginalUsername = username
                };

                int rowsAffected = connection.Execute(updateQuery, parameters); // ✅ no commandType here

                if (rowsAffected > 0)
                {
                    XtraMessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("No record updated. Employee may not exist.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }
        private void saveBTN_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(firstnameTE.Text) ||
                string.IsNullOrWhiteSpace(lastnameTE.Text) ||
                string.IsNullOrWhiteSpace(usernameTE.Text))
            {
                XtraMessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var employee = new Employees.Employee
            {
                RoleID = positionRG.SelectedIndex + 1,
                FirstName = firstnameTE.Text.Trim(),
                MiddleName = middlenameTE.Text.Trim(),
                LastName = lastnameTE.Text.Trim(),
                NameExtension = extensionTE.Text.Trim(),
                ContactNo = contactnoTE.Text.Trim(),
                Address = addressTE.Text.Trim(),
                Username = usernameTE.Text.Trim(),
                //Password = finalPassword,
                EmploymentStatus = employeeRG.SelectedIndex + 1,
                StatusID = 1, // Optional: Replace if needed
                IsLocked = accountTS.IsOn ? 1 : 0

            };

            bool result = UpdateEmployee(employee, username);

            if (result)
            {
                this.Close();
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult confirm = XtraMessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (var connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                string deleteQuery = @"DELETE FROM emp.Employees WHERE Username = @Username";

                int rowsAffected = connection.Execute(deleteQuery, new { Username = username });

                if (rowsAffected > 0)
                {
                    XtraMessageBox.Show("Employee deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the edit form
                }
                else
                {
                    XtraMessageBox.Show("Failed to delete. Employee may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changepasswordHLBL_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new ChangePasswordForm(username), () =>
            {
                LoadEmployeeData();
            });
        }
    }
}



