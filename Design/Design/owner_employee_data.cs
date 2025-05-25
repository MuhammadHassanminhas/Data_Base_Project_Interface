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
            LoadPositions();
            employee_dataGridView.CellClick += employee_dataGridView_CellClick;
            position_dropdown.SelectedIndex = -1;

        }
        private void LoadPositions()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT Role FROM Staff", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    position_dropdown.Items.Add(reader["Role"].ToString());
                }

                reader.Close();
            }
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
            try
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

                emp_name.Clear();
                emp_address.Clear();
                emp_contact.Clear();
                emp_cnic.Clear();
                emp_id.Clear();
                position_dropdown.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Insert failed: Staff ID already exists"))
                {
                    MessageBox.Show("Error: This Staff ID already exists. Please use a different one.");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
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
            emp_name.Clear();
            emp_address.Clear();
            emp_contact.Clear();
            emp_cnic.Clear();
            emp_id.Clear();
            position_dropdown.SelectedIndex = -1;
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
            emp_name.Clear();
            emp_address.Clear();
            emp_contact.Clear();
            emp_cnic.Clear();
            emp_id.Clear();
            position_dropdown.SelectedIndex = -1;
        }
    }
}
