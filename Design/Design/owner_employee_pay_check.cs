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
    public partial class owner_employee_pay_check : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public owner_employee_pay_check()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int staffId = Convert.ToInt32(id.Text);
            DateTime payPeriod = dateTimePicker1.Value.Date;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("GetEmployeePaycheck", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_StaffID", staffId);
                cmd.Parameters.AddWithValue("@p_PayPeriod", payPeriod);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name.Text = reader["Name"].ToString();
                    salaryperday.Text = reader["Salary_Per_Day"].ToString();
                    absents.Text = reader["Absents"].ToString();
                    tips.Text = reader["Tips"].ToString();
                    deduction.Text = reader["Deduction"].ToString();
                    netsalary.Text = reader["Net_Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("No paycheck record found for this employee and period.");
                }

                reader.Close();
            }
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("InsertEmployeePaycheck", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_StaffID", Convert.ToInt32(id.Text));
                cmd.Parameters.AddWithValue("@p_PayPeriod", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@p_Salary_Per_Day", Convert.ToDecimal(salaryperday.Text));
                cmd.Parameters.AddWithValue("@p_Absents", Convert.ToInt32(absents.Text));
                cmd.Parameters.AddWithValue("@p_Tips", Convert.ToDecimal(tips.Text));
                cmd.Parameters.AddWithValue("@p_Deduction", Convert.ToDecimal(deduction.Text));
                cmd.Parameters.AddWithValue("@p_Net_Salary", Convert.ToDecimal(netsalary.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paycheck released successfully.");
            }
        }
    }
}
