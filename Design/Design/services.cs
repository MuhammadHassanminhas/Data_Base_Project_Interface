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
using System.Xml.Linq;

namespace Design
{
    public partial class services : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";

        public services()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("InsertService", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_Name", service_name.Text);
                cmd.Parameters.AddWithValue("@p_Price", Convert.ToDecimal(service_price.Text));
                cmd.Parameters.AddWithValue("@p_Duration", Convert.ToInt16(service_duration.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service Added!");
                LoadServices();  // Refresh grid
            }

        }

        private void EDIT_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateService", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_ServiceID", Convert.ToInt32(service_id.Text));
                cmd.Parameters.AddWithValue("@p_Name", service_name.Text);
                cmd.Parameters.AddWithValue("@p_Price", Convert.ToDecimal(service_price.Text));
                cmd.Parameters.AddWithValue("@p_Duration", Convert.ToInt16(service_duration.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service Updated!");
                LoadServices();
            }

        }

        private void DELETE_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteService", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_ServiceID", Convert.ToInt32(service_id.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service Deleted!");
                LoadServices();
            }

        }
        private void LoadServices()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("GetAllServices", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                STOCK_dataGridView.DataSource = dt;
            }
        }

        private void services_Load(object sender, EventArgs e)
        {
            LoadServices();
        }
    }
}
