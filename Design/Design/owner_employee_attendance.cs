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
    public partial class owner_employee_attendance : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";

        public owner_employee_attendance()
        {
            InitializeComponent();
        }

        private void owner_employee_attendance_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT Role FROM Staff", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    position_category.Items.Add(reader["Role"].ToString());
                }
                reader.Close();
            }
            status_category.Items.AddRange(new string[] { "Present", "Absent", "Leave" });
            LoadAttendanceData();
        }
        private void LoadAttendanceData()
        {
            string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("GetAllAttendance", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                attendence_dataGridView.DataSource = dt;
            }
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("InsertAttendance", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_StaffID", Convert.ToInt32(emp_id.Text));
                cmd.Parameters.AddWithValue("@p_Status", status_category.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@p_AttendanceDate", dateTimePicker1.Value.Date);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance added successfully.");
                LoadAttendanceData();
            }
        }

        private void DELETE_BUTTON_Click(object sender, EventArgs e)
        {
            if (attendence_dataGridView.SelectedRows.Count > 0)
            {
                int attendanceId = Convert.ToInt32(attendence_dataGridView.SelectedRows[0].Cells["Attendance_ID"].Value);

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DeleteAttendance", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_AttendanceID", attendanceId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record deleted.");
                    LoadAttendanceData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void EDIT_BUTTON_Click(object sender, EventArgs e)
        {
            if (attendence_dataGridView.SelectedRows.Count > 0)
            {
                int attendanceId = Convert.ToInt32(attendence_dataGridView.SelectedRows[0].Cells["Attendance_ID"].Value);

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UpdateAttendance", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_AttendanceID", attendanceId);
                    cmd.Parameters.AddWithValue("@p_Status", status_category.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@p_AttendanceDate", dateTimePicker1.Value.Date);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance record updated.");
                    LoadAttendanceData();
                }
            }
            else
            {
                MessageBox.Show("Select a record to update.");
            }
        }
    }
}
