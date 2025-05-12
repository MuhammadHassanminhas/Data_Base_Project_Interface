using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Design
{
    public partial class owner_employee_data : Form
    {
        string connStr = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public owner_employee_data()
        {
            InitializeComponent();
            LoadEmployees();
            position_dropdown.Items.AddRange(new string[] { "Hair Stylist", "Receptionist", "Manager" });
            employee_dataGridView.CellClick += employee_dataGridView_CellClick;

        }

        private void employee_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employee_dataGridView.Rows[e.RowIndex];
                emp_id.Text = row.Cells["Staff_ID"].Value.ToString();
                emp_name.Text = row.Cells["Name"].Value.ToString();
                position_dropdown.Text = row.Cells["Role"].Value.ToString();
                emp_cnic.Text = row.Cells["CNIC_Number"].Value.ToString();
                emp_contact.Text = row.Cells["Contact_Number"].Value.ToString();
                emp_address.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void LoadEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("GetAllEmployees", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                employee_dataGridView.DataSource = dt;
            }
        }
        private void owner_employee_data_Load(object sender, EventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("InsertEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StaffID", Convert.ToInt32(emp_id.Text));
                cmd.Parameters.AddWithValue("p_Name", emp_name.Text);
                cmd.Parameters.AddWithValue("p_Role", position_dropdown.Text);
                cmd.Parameters.AddWithValue("p_CNIC", emp_cnic.Text);
                cmd.Parameters.AddWithValue("p_Address", emp_address.Text);
                cmd.Parameters.AddWithValue("p_Contact", emp_contact.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee added!");
                LoadEmployees();
            }
        }

        private void EDIT_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StaffID", Convert.ToInt32(emp_id.Text));
                cmd.Parameters.AddWithValue("p_Name", emp_name.Text);
                cmd.Parameters.AddWithValue("p_Role", position_dropdown.Text);
                cmd.Parameters.AddWithValue("p_CNIC", emp_cnic.Text);
                cmd.Parameters.AddWithValue("p_Address", emp_address.Text);
                cmd.Parameters.AddWithValue("p_Contact", emp_contact.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee updated!");
                LoadEmployees();
            }
        }

        private void DELETE_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StaffID", Convert.ToInt32(emp_id.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted!");
                LoadEmployees();
            }
        }
    }
}
