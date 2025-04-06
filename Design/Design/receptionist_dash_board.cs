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
    public partial class receptionist_dash_board : Form
    {
        public receptionist_dash_board()
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
        private void receptionist_dash_board_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_form_obj(new receptionist_appointment());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_form_obj(new recdeptionist_generate_bill());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_form_obj(new receptionist_view_client_data());
        }
    }
}
