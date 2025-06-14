﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class manager_login : Form
    {
        public manager_login()
        {
            InitializeComponent();
            ApplyRoundedButtons();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void hide_button_Click(object sender, EventArgs e)
        {
            if (textBox_login_password.PasswordChar == '\0')
            {
                show_button.BringToFront();
                textBox_login_password.PasswordChar = '*';
            }
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            if (textBox_login_password.PasswordChar == '*')
            {
                hide_button.BringToFront();
                textBox_login_password.PasswordChar = '\0';
            }
        }

        private void owner_login_up_button_Click(object sender, EventArgs e)
        {
            manager_dash_board loginForm = new manager_dash_board();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            back_button.BackColor = Color.Transparent;
            sign_up_main signupForm = new sign_up_main();
            this.Hide(); // Hides the current form
            signupForm.ShowDialog(); // Opens the new form in a modal way
            this.Show();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
