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
using Org.BouncyCastle.Asn1.Ocsp;

namespace Design
{
    public partial class employee_dash_board : Form
    {
        private int StaffID;
        string connectionString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public employee_dash_board(int empid)
        {
            InitializeComponent();
            StaffID = empid;
            LoadEmployeeDetails();
            LoadAttendance();
        }

        private void employee_logout_Click(object sender, EventArgs e)
        {
            employee loginForm = new employee();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }
        private void LoadEmployeeDetails()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("sp_GetEmployeeProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_StaffID", StaffID);

                try
                {
                    con.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp_Name.Text = reader["Name"].ToString();
                            ID.Text = reader["Staff_ID"].ToString();
                            cnic.Text = reader["CNIC_Number"].ToString();
                            contact.Text = reader["Contact_Number"].ToString();
                            address.Text = reader["Address"].ToString();
                            tips.Text = reader["MonthlyTips"].ToString();
                            paycheck.Text = reader["MonthlyPaycheck"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee details: " + ex.Message);
                }
            }
        }

        private void LoadAttendance()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("sp_GetEmployeeAttendance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_StaffID", StaffID);

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    attendence_dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading attendance: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("sp_FilterAttendanceForEmployee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parameters
                        cmd.Parameters.AddWithValue("@p_StaffID", ID); // Replace ID with the staff ID variable or control value
                        cmd.Parameters.AddWithValue("@p_Date", dateTimePicker1.Value.Date);

                        // Adapter and DataTable
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind data to DataGridView
                        attendence_dataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
