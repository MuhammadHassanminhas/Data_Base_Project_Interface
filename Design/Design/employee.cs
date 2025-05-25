using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design
{
    public partial class employee : Form
    {
        private string connectionString = "server=localhost;database=beauty_salon;uid=root;pwd=root;";
        public employee()
        {
            InitializeComponent();
            ApplyRoundedButtons();
        }

        private void ApplyRoundedButtons()
        {
            // Apply rounded corners to buttons on form load
            MakeButtonRounded(owner_login_up_button);
        }
        private void MakeButtonRounded(Button btn)
        {
            int radius = 30; // Change this for more or less rounding
            GraphicsPath grp = new GraphicsPath();
            grp.AddArc(0, 0, radius, radius, 180, 90);
            grp.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            grp.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            grp.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            grp.CloseFigure();
            btn.Region = new Region(grp);
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            back_button.BackColor = Color.Transparent;
            sign_up_main signupForm = new sign_up_main();
            this.Hide(); // Hides the current form
            signupForm.ShowDialog(); // Opens the new form in a modal way
            this.Show();
        }
        private void hide_button_Click(object sender, EventArgs e)
        {
            if (emp_password.PasswordChar == '\0')
            {
                show_button.BringToFront();
                emp_password.PasswordChar = '*';
            }
        }


        private void show_button_Click(object sender, EventArgs e)
        {
            if (emp_password.PasswordChar == '*')
            {
                hide_button.BringToFront();
                emp_password.PasswordChar = '\0';
            }
        }

        private void owner_login_up_button_Click(object sender, EventArgs e)
        {
            int staffID;
            if (!int.TryParse(Employee_ID.Text.Trim(), out staffID))
            {
                MessageBox.Show("Please enter a valid Staff ID.");
                return;
            }

            string password = emp_password.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand("EmployeeLogin", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp_id", staffID);
                cmd.Parameters.AddWithValue("@emp_pass", password);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            // Open Employee Dashboard
                            employee_dash_board dashboard = new employee_dash_board(staffID);
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
