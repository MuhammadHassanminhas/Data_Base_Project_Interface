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
    public partial class manager_employee_data : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public manager_employee_data()
        {
            InitializeComponent();
            LoadEmployees();
        }
        private void LoadEmployees()
        {
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Call stored procedure to fetch all employees
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("CALL GetAllEmployees()", connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the data to DataGridView
                    EMPLOYEE_dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employees: " + ex.Message);
                }
            }
        }

        private void SEARCH_BUTTON_Click(object sender, EventArgs e)
        {
            string staffId = emp_id.Text;
            string name = emp_name.Text;

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    // Create command for stored procedure
                    MySqlCommand command = new MySqlCommand("GetEmployeeByIdAndName", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to filter by Staff_ID or Name
                    command.Parameters.AddWithValue("p_StaffID", string.IsNullOrEmpty(staffId) ? (object)DBNull.Value : int.Parse(staffId));
                    command.Parameters.AddWithValue("p_Name", string.IsNullOrEmpty(name) ? (object)DBNull.Value : name);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the filtered data to DataGridView
                    EMPLOYEE_dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching employees: " + ex.Message);
                }
            }
        }

        private void manager_employee_data_Load(object sender, EventArgs e)
        {
        }
    }
}
