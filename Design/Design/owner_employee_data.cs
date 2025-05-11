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
    public partial class owner_employee_data : Form
    {
        string connString = "server=localhost;uid=root;pwd=root;database=beauty_salon;";
        public owner_employee_data()
        {
            InitializeComponent();
        }

        private void owner_employee_data_Load(object sender, EventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            
        }
    }
}
