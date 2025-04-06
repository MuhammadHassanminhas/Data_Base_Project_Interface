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
    public partial class manager_dash_board : Form
    {
        public manager_dash_board()
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
        bool manager_record_menu_expand = false;
        private void RECORD_MENU_TIMER_MANAGER_Tick(object sender, EventArgs e)
        {
            if (manager_record_menu_expand == false)
            {
                RECORDS_MENU.Height += 10;
                if (RECORDS_MENU.Height >= 153)
                {
                    RECORD_MENU_TIMER_MANAGER.Stop();
                    manager_record_menu_expand = true;
                }
            }
            else
            {
                RECORDS_MENU.Height -= 10;
                if (RECORDS_MENU.Height <= 43)
                {
                    RECORD_MENU_TIMER_MANAGER.Stop();
                    manager_record_menu_expand = false;
                }
            }
        }

        private void manager_records_Click(object sender, EventArgs e)
        {
            RECORD_MENU_TIMER_MANAGER.Start();
        }

        private void manager_stock_Click(object sender, EventArgs e)
        {
            load_form_obj(new stock_owner());
        }

        private void manager_attendence_Click(object sender, EventArgs e)
        {
            load_form_obj(new manager_attendence());
        }

        private void manager_sallary_Click(object sender, EventArgs e)
        {
            load_form_obj(new manager_salary());
        }

        private void manager_tips_Click(object sender, EventArgs e)
        {
            load_form_obj(new manager_tips());
        }

        private void manager_services_Click(object sender, EventArgs e)
        {
            load_form_obj(new services());
        }

        private void MANAGER_EMPLOYEE_RECORDS_Click(object sender, EventArgs e)
        {
            load_form_obj(new manager_employee_data());
        }

        private void MANAGER_CLIENT_RECORDS_Click(object sender, EventArgs e)
        {
            load_form_obj(new owner_client_data());
        }
    }
}
