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
    }
}
