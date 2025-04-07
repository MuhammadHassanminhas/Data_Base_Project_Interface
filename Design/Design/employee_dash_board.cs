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
    public partial class employee_dash_board : Form
    {
        public employee_dash_board()
        {
            InitializeComponent();
        }

        private void employee_logout_Click(object sender, EventArgs e)
        {
            employee loginForm = new employee();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }
    }
}
