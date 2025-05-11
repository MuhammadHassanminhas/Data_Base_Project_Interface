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
    public partial class total_earnings : Form
    {
        private string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public total_earnings()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("GetTotalEarningsByDate", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Pass the selected date from the DateTimePicker to the stored procedure
                    cmd.Parameters.AddWithValue("@target_date", dateTimePicker1.Value.Date);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assign values to labels or textboxes
                            dateTimePicker1.Text = Convert.ToDateTime(reader["Selected_Date"]).ToShortDateString();
                            tips.Text = reader["Total_Tips"].ToString();
                            total_services.Text = reader["Total_Services"].ToString();
                            salary.Text = reader["Total_Employee_Salaries"].ToString();
                            revenue.Text = reader["Total_Service_Revenue"].ToString();
                            net_income.Text = reader["Net_Income"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No data found for the selected date.");
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
}
