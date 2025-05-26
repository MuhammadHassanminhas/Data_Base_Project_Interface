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
using System.Drawing.Text;

namespace Design
{
    public partial class stock_owner : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public stock_owner()
        {
            InitializeComponent();
            STOCK_dataGridView.CellClick += stock_dataGridView_CellClick;
        }

        private void stock_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = STOCK_dataGridView.Rows[e.RowIndex];
                stock_ID.Text = row.Cells["Product_ID"].Value.ToString();
                stock_name.Text = row.Cells["Product_Name"].Value.ToString();
                stock_quantity.Text = row.Cells["Quantity"].Value.ToString();
                stock_price.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("InsertStock", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ProductID", Convert.ToInt32(stock_ID.Text));
                    cmd.Parameters.AddWithValue("@p_ProductName", stock_name.Text);
                    cmd.Parameters.AddWithValue("@p_Quantity", Convert.ToInt32(stock_quantity.Text));
                    cmd.Parameters.AddWithValue("@p_Price", Convert.ToDecimal(stock_price.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stock added successfully.");
                    LoadInventory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            stock_ID.Clear();
            stock_quantity.Clear();
            stock_price.Clear();
            stock_name.Clear();
        }

        private void EDIT_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UpdateStock", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ProductID", Convert.ToInt32(stock_ID.Text));
                    cmd.Parameters.AddWithValue("@p_ProductName", stock_name.Text);
                    cmd.Parameters.AddWithValue("@p_Quantity", Convert.ToInt32(stock_quantity.Text));
                    cmd.Parameters.AddWithValue("@p_Price", Convert.ToDecimal(stock_price.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stock updated successfully.");
                    LoadInventory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            stock_ID.Clear();
            stock_quantity.Clear();
            stock_price.Clear();
            stock_name.Clear();
        }

        private void DELETE_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DeleteStock", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ProductID", Convert.ToInt32(stock_ID.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stock deleted successfully.");
                    LoadInventory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            stock_ID.Clear();
            stock_quantity.Clear();
            stock_price.Clear();
            stock_name.Clear();
        }

        private void STOCK_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void LoadInventory()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Inventory", conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    STOCK_dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory: " + ex.Message);
                }
            }
        }

        private void stock_owner_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }
    }
}
