using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class owner_dash_board : Form
    {

        public owner_dash_board()
        {
            InitializeComponent();
        }
        public void load_form_obj(object form)
        {
            if (this.main_panel.Controls.Count > 0)
                this.main_panel.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(fh);
            this.main_panel.Tag = fh;
            fh.Show();
        }
        bool employee_menu_expand = false;

        private void employee_menu_timer_Tick(object sender, EventArgs e)
        {
            if (employee_menu_expand == false)
            {
                employee_menu_container.Height += 10;
                if (employee_menu_container.Height >= 153)
                {
                    employee_menu_timer.Stop();
                    employee_menu_expand = true;
                }
            }
            else
            {
                employee_menu_container.Height -= 10;
                if (employee_menu_container.Height <= 43)
                {
                    employee_menu_timer.Stop();
                    employee_menu_expand = false;
                }
            }
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            employee_menu_timer.Start();
        }

        private void employee_menu_container_Paint(object sender, PaintEventArgs e)
        {

        }
        bool record_menu_expand = false;
        private void record_menu_timer_Tick(object sender, EventArgs e)
        {
            if (record_menu_expand == false)
            {
                records_menu_container.Height += 10;
                if (records_menu_container.Height >= 153)
                {
                    record_menu_timer.Stop();
                    record_menu_expand = true;
                }
            }
            else
            {
                records_menu_container.Height -= 10;
                if (records_menu_container.Height <= 43)
                {
                    record_menu_timer.Stop();
                    record_menu_expand = false;
                }
            }
        }

        private void records_button_Click(object sender, EventArgs e)
        {
            record_menu_timer.Start();
        }

        private void owner_dash_board_Load(object sender, EventArgs e)
        {

        }

        private void total_earning_Click(object sender, EventArgs e)
        {
            load_form_obj(new total_earnings());
        }



        private void paycheck_button_Click(object sender, EventArgs e)
        {
            load_form_obj(new owner_employee_pay_check());
        }

        private void owner_stock_Click(object sender, EventArgs e)
        {
            load_form_obj(new stock_owner());
        }

        private void services_Click(object sender, EventArgs e)
        {
            load_form_obj(new services());
        }

        private void attendence_button_Click(object sender, EventArgs e)
        {
            load_form_obj(new owner_employee_attendance());
        }

        private void employee_record_button_Click(object sender, EventArgs e)
        {
            load_form_obj(new owner_employee_data());
        }

        private void client_record_button_Click(object sender, EventArgs e)
        {
            load_form_obj(new owner_client_data());
        }

        private void owner_menu_Click(object sender, EventArgs e)
        {
            sign_up_main loginForm = new sign_up_main();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }

        private void owner_logout_Click(object sender, EventArgs e)
        {
            owner_login loginForm = new owner_login();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }
    }
}
