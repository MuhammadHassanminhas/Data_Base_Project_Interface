using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design
{
    public partial class manager_salary : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public manager_salary()
        {
            InitializeComponent();
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            string employeeName = emp_name.Text.Trim();
            string employeeID = emp_id.Text.Trim();

            int parsedID;
            int? idParam = int.TryParse(employeeID, out parsedID) ? parsedID : (int?)null;
            string nameParam = string.IsNullOrWhiteSpace(employeeName) ? null : employeeName;

            GetEmployeePaycheck(idParam, nameParam);
            emp_id.Clear();
            emp_name.Clear();
        }
        private void GetEmployeePaycheck(int? staffID, string staffName)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("GetFilteredPaychecks", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_StaffID", staffID.HasValue ? (object)staffID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@p_StaffName", string.IsNullOrEmpty(staffName) ? DBNull.Value : (object)staffName);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                EMPLOYEE_dataGridView.DataSource = dt;
            }
        }
        private void LoadAllPaychecks()
        {
            GetEmployeePaycheck(null, null);
        }

        private void manager_salary_Load(object sender, EventArgs e)
        {
            LoadAllPaychecks();
        }
    }
}
