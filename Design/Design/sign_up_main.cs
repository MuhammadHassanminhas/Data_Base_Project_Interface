using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Design
{
    public partial class sign_up_main : Form
    {
        public sign_up_main()
        {
            InitializeComponent();
            ApplyRoundedButtons();
        }

        private void ApplyRoundedButtons()
        {
            // Apply rounded corners to buttons on form load
            MakeButtonRounded(owner_sign_up_button);
            MakeButtonRounded(manager_sign_up_button);
            MakeButtonRounded(receptionist_sign_up_button);
            MakeButtonRounded(employee_signUp_button);
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

        private void sign_up_page_panel_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting logic if needed
        }

        private void owner_sign_up_button_Click(object sender, EventArgs e)
        {
            owner_login loginForm = new owner_login();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }

        private void welcome_back_Click(object sender, EventArgs e)
        {
        }

        private void sign_up_main_Load(object sender, EventArgs e)
        {

        }

        private void receptionist_sign_up_button_Click(object sender, EventArgs e)
        {
            receptionist_login loginForm = new receptionist_login();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }
    }
}
