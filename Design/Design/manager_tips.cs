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
    public partial class manager_tips : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public manager_tips()
        {
            InitializeComponent();
            LoadTips();
            UpdateButtonStates();
            TIP_dataGridView.CellClick += TIP_dataGridView_CellClick;
            service_category.SelectedIndex = -1;
        }
        private void TIP_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TIP_dataGridView.Rows[e.RowIndex];

                // Display the data in the appropriate input fields (except Tip_ID)
                emp_id.Text = row.Cells["Staff_ID"].Value.ToString(); // Staff ID
                emp_name.Text = row.Cells["Employee_Name"].Value.ToString(); // Employee Name
                service_category.SelectedItem = row.Cells["Service_Name"].Value.ToString(); // Service Name
                amount_tip.Text = row.Cells["Amount"].Value.ToString(); // Tip Amount
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Tip_Date"].Value.ToString()); // Tip Date
            }
        }


        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(emp_id.Text, out int staffId) || !decimal.TryParse(amount_tip.Text, out decimal amount))
            {
                MessageBox.Show("Please enter valid employee ID and tip amount.");
                return;
            }

            if (service_category.SelectedValue == null)
            {
                MessageBox.Show("Please select a service category.");
                return;
            }

            int serviceId = Convert.ToInt32(service_category.SelectedValue);
            DateTime date = dateTimePicker1.Value;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("InsertTip", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_StaffID", staffId);
                    cmd.Parameters.AddWithValue("@p_ServiceID", serviceId);
                    cmd.Parameters.AddWithValue("@p_Amount", amount);
                    cmd.Parameters.AddWithValue("@p_TipDate", date);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tip added successfully.");
                LoadTips();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            emp_name.Clear();
            emp_id.Clear();
            amount_tip.Clear();
            service_category.SelectedIndex = -1;
        }

        private void EDIT_BUTTON_Click(object sender, EventArgs e)
        {
            if (TIP_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a tip record to update.");
                return;
            }

            // Input validation
            if (!int.TryParse(emp_id.Text, out int staffId) || !decimal.TryParse(amount_tip.Text, out decimal amount))
            {
                MessageBox.Show("Please enter valid employee ID and tip amount.");
                return;
            }

            if (service_category.SelectedValue == null)
            {
                MessageBox.Show("Please select a service category.");
                return;
            }
            int serviceId = Convert.ToInt32(service_category.SelectedValue);

            int tipId = Convert.ToInt32(TIP_dataGridView.SelectedRows[0].Cells["Tip_ID"].Value);
            //int serviceId = (int)service_category.SelectedValue;
            DateTime date = dateTimePicker1.Value;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UpdateTip", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_TipID", tipId);
                    cmd.Parameters.AddWithValue("@p_StaffID", staffId);
                    cmd.Parameters.AddWithValue("@p_ServiceID", serviceId);
                    cmd.Parameters.AddWithValue("@p_Amount", amount);
                    cmd.Parameters.AddWithValue("@p_TipDate", date);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tip updated successfully.");
                LoadTips();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            emp_name.Clear();
            emp_id.Clear();
            amount_tip.Clear();
            service_category.SelectedIndex = -1;
        }

        private void DELETE_BUTTON_Click(object sender, EventArgs e)
        {
            if (TIP_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a tip record to delete.");
                return;
            }

            int tipId = Convert.ToInt32(TIP_dataGridView.SelectedRows[0].Cells["Tip_ID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this tip?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DeleteTip", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_TipID", tipId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tip deleted successfully.");
                    LoadTips();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                emp_name.Clear();
                emp_id.Clear();
                amount_tip.Clear();
                service_category.SelectedIndex = -1;
            }
        }
        private void LoadTips()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("CALL GetAllTips()", conn); // Ensure your stored procedure returns Staff_ID
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Ensure the DataGridView is properly bound to the DataTable
                    TIP_dataGridView.DataSource = dt;

                    // Check if the column exists
                    if (TIP_dataGridView.Columns.Contains("Staff_ID"))
                    {
                        // If the column exists, set the header text
                        TIP_dataGridView.Columns["Staff_ID"].HeaderText = "Employee ID"; // Modify if needed
                    }
                    else
                    {
                        MessageBox.Show("The 'Staff_ID' column does not exist in the data.");
                    }
                }

                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tips: {ex.Message}");
            }
        }
        private void UpdateButtonStates()
        {
            // Disable Edit and Delete buttons if no row is selected
            bool isRowSelected = TIP_dataGridView.SelectedRows.Count > 0;
            EDIT_BUTTON.Enabled = isRowSelected;
            DELETE_BUTTON.Enabled = isRowSelected;
        }
        private void TIP_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void manager_tips_Load(object sender, EventArgs e)
        {
            LoadTips();
            LoadServices();
            TIP_dataGridView.SelectionChanged += TIP_dataGridView_SelectionChanged;
        }
        private void LoadServices()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Service_ID, Name FROM Service", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                service_category.DataSource = dt;
                service_category.DisplayMember = "Name";      // What user sees
                service_category.ValueMember = "Service_ID"; // The ID used internally
            }
        }
    }
}
