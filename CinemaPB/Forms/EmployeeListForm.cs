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
using CinemaPB.Employees;
using CinemaPB.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker.Parser;

namespace CinemaPB.Forms
{
    public partial class EmployeeListForm : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeeListForm()
        {
            InitializeComponent();
            FilterAllEmployees();
        }

        private void addemployeeBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new SignUpForm());
        }

        private DataTable FilterAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();
                string query = GlobalSQL.SQLQuery.FilterAllEmployees;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gcEmployees.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvEmployees.ApplyFindFilter(e.NewValue as string);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string selectedUsername = Convert.ToString(gvEmployees.GetFocusedRowCellValue("Username"));

            using (EditDeleteEmployeeForm employeeRecordView = new EditDeleteEmployeeForm(selectedUsername))
            {
                employeeRecordView.ShowDialog();
            }
            FilterAllEmployees();
        }

        private void gvEmployees_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string selectedUsername = Convert.ToString(gvEmployees.GetRowCellValue(e.RowHandle, "Username"));

            if (!string.IsNullOrEmpty(selectedUsername))
            {
                using (EditDeleteEmployeeForm editForm = new EditDeleteEmployeeForm(selectedUsername))
                {
                    editForm.ShowDialog();
                }

                FilterAllEmployees();
            }
        }
    }
}
