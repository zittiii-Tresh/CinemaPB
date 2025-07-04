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
using CinemaPB.Forms;
using DevExpress.XtraEditors;

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
                        employeeGC.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }
    }
}
