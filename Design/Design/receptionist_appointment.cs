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
    public partial class receptionist_appointment : Form
    {
        private string connectionString = "server=localhost;user id=root;password=root;database=BEAUTY_SALON;";
        public receptionist_appointment()
        {
            InitializeComponent();
            LoadServices();
            LoadAppointments();
        }

        private void LoadServices()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT Service_ID, Name FROM Service";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Service_ID";
            }
        }

        private void LoadAppointments()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                SELECT a.Appointment_ID, c.Name AS Client, c.Contact_Number, 
                       s.Name AS Service, a.Date, a.Time, st.Name AS Staff
                FROM Appointment a
                JOIN Client c ON a.Client_ID = c.Client_ID
                JOIN Service s ON a.Service_ID = s.Service_ID
                JOIN Staff st ON a.Staff_ID = st.Staff_ID
                ORDER BY a.Date DESC, a.Time DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void service_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            string clientName = name.Text.Trim();
            string contactNumber = contact.Text.Trim();
            int serviceID = Convert.ToInt32(comboBox1.SelectedValue);
            int employeeID = Convert.ToInt32(emp_id.Text.Trim());

            // Separate Date and Time
            DateTime selectedDateTime = dateTimePicker1.Value;
            DateTime dateOnly = selectedDateTime.Date;
            TimeSpan timeOnly = selectedDateTime.TimeOfDay;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("AddAppointment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_ClientName", clientName);
                cmd.Parameters.AddWithValue("@p_ContactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@p_ServiceID", serviceID);
                cmd.Parameters.AddWithValue("@p_EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@p_Date", dateOnly);
                cmd.Parameters.AddWithValue("@p_Time", timeOnly);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAppointments(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding appointment:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
