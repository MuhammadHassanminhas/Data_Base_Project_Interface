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
    public partial class receptionist_view_client_data : Form
    {
        private string connStr = "server=localhost;user id=root;password=root;database=beauty_salon";
        public receptionist_view_client_data()
        {
            InitializeComponent();
            LoadClients();
        }
        private void LoadClients(string nameFilter = "", string contactFilter = "")
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                // Start base query
                string query = @"SELECT * FROM Client WHERE 1=1";

                // Add filters conditionally
                if (!string.IsNullOrEmpty(nameFilter))
                {
                    query += " AND Name LIKE @Name";
                }

                if (!string.IsNullOrEmpty(contactFilter))
                {
                    query += " AND Contact_Number LIKE @Contact";
                }

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrEmpty(nameFilter))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + nameFilter + "%");
                }

                if (!string.IsNullOrEmpty(contactFilter))
                {
                    cmd.Parameters.AddWithValue("@Contact", "%" + contactFilter + "%");
                }

                using MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                client_dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading client data: " + ex.Message);
            }
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            string Name = name.Text.Trim();
            string Contact = contact.Text.Trim();

            LoadClients(Name, Contact);
        }
    }
}
