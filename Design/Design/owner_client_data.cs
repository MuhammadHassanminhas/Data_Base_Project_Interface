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
    public partial class owner_client_data : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public owner_client_data()
        {
            InitializeComponent();
            CLIENT_dataGridView.CellClick += client_dataGridView_CellClick;
            LoadClientData();
        }
        private void client_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CLIENT_dataGridView.Rows[e.RowIndex];

                client_ID.Text = row.Cells["Client_ID"].Value.ToString();
                client_name.Text = row.Cells["Name"].Value.ToString();
                client_contact.Text = row.Cells["Contact_Number"].Value.ToString();
                client_address.Text = row.Cells["Address"].Value.ToString();
            }
        }
        private void LoadClientData()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("GetAllClients", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CLIENT_dataGridView.DataSource = dt;
            }
        }

        private void DELETE_BUTTON_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(client_ID.Text))
            {
                MessageBox.Show("Please select a client to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DeleteClient", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_ClientID", client_ID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client deleted successfully.");
                    LoadClientData();
                    ClearFields();
                }
            }
        }
        private void ClearFields()
        {
            client_name.Clear();
            client_contact.Clear();
            client_address.Clear();
            client_ID.Clear();
        }
        private void EDIT_BUTTON_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(client_ID.Text))
            {
                MessageBox.Show("Please select a client to update.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateClient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_ClientID", client_ID.Text);
                cmd.Parameters.AddWithValue("@p_Name", client_name.Text);
                cmd.Parameters.AddWithValue("@p_Contact_Number", client_contact.Text);
                cmd.Parameters.AddWithValue("@p_Address", client_address.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client updated successfully.");
                LoadClientData();
                ClearFields();
            }
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(client_name.Text) ||
                string.IsNullOrWhiteSpace(client_contact.Text) ||
                string.IsNullOrWhiteSpace(client_address.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("InsertClient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_Name", client_name.Text);
                cmd.Parameters.AddWithValue("@p_Contact_Number", client_contact.Text);
                cmd.Parameters.AddWithValue("@p_Address", client_address.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client added successfully.");
                LoadClientData();
                ClearFields();
            }
        }
    }
}
