namespace Design
{
    partial class sign_up_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up_main));
            sign_up_page_panel = new Panel();
            logo_signup_main = new Panel();
            employee_signUp_button = new Button();
            receptionist_sign_up_button = new Button();
            manager_sign_up_button = new Button();
            owner_sign_up_button = new Button();
            welcome_back = new Label();
            close_button = new Button();
            sign_up_page_panel.SuspendLayout();
            SuspendLayout();
            // 
            // sign_up_page_panel
            // 
            sign_up_page_panel.BackColor = Color.White;
            sign_up_page_panel.Controls.Add(logo_signup_main);
            sign_up_page_panel.Controls.Add(employee_signUp_button);
            sign_up_page_panel.Controls.Add(receptionist_sign_up_button);
            sign_up_page_panel.Controls.Add(manager_sign_up_button);
            sign_up_page_panel.Controls.Add(owner_sign_up_button);
            sign_up_page_panel.Controls.Add(welcome_back);
            sign_up_page_panel.Location = new Point(95, 33);
            sign_up_page_panel.Name = "sign_up_page_panel";
            sign_up_page_panel.Size = new Size(1200, 600);
            sign_up_page_panel.TabIndex = 0;
            sign_up_page_panel.Paint += sign_up_page_panel_Paint;
            // 
            // logo_signup_main
            // 
            logo_signup_main.BackgroundImage = (Image)resources.GetObject("logo_signup_main.BackgroundImage");
            logo_signup_main.BackgroundImageLayout = ImageLayout.Zoom;
            logo_signup_main.Location = new Point(12, 309);
            logo_signup_main.Name = "logo_signup_main";
            logo_signup_main.Size = new Size(178, 288);
            logo_signup_main.TabIndex = 5;
            // 
            // employee_signUp_button
            // 
            employee_signUp_button.AutoSize = true;
            employee_signUp_button.BackColor = Color.FromArgb(255, 136, 183);
            employee_signUp_button.FlatStyle = FlatStyle.Flat;
            employee_signUp_button.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee_signUp_button.ForeColor = Color.White;
            employee_signUp_button.Location = new Point(462, 375);
            employee_signUp_button.Name = "employee_signUp_button";
            employee_signUp_button.Size = new Size(277, 58);
            employee_signUp_button.TabIndex = 4;
            employee_signUp_button.Text = "Employee";
            employee_signUp_button.UseVisualStyleBackColor = false;
            employee_signUp_button.Click += employee_signUp_button_Click;
            // 
            // receptionist_sign_up_button
            // 
            receptionist_sign_up_button.AutoSize = true;
            receptionist_sign_up_button.BackColor = Color.FromArgb(255, 136, 183);
            receptionist_sign_up_button.FlatStyle = FlatStyle.Flat;
            receptionist_sign_up_button.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receptionist_sign_up_button.ForeColor = Color.White;
            receptionist_sign_up_button.Location = new Point(462, 481);
            receptionist_sign_up_button.Name = "receptionist_sign_up_button";
            receptionist_sign_up_button.Size = new Size(277, 58);
            receptionist_sign_up_button.TabIndex = 3;
            receptionist_sign_up_button.Text = "Receptionist";
            receptionist_sign_up_button.UseVisualStyleBackColor = false;
            receptionist_sign_up_button.Click += receptionist_sign_up_button_Click;
            // 
            // manager_sign_up_button
            // 
            manager_sign_up_button.AutoSize = true;
            manager_sign_up_button.BackColor = Color.FromArgb(255, 136, 183);
            manager_sign_up_button.FlatStyle = FlatStyle.Flat;
            manager_sign_up_button.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manager_sign_up_button.ForeColor = Color.White;
            manager_sign_up_button.Location = new Point(462, 269);
            manager_sign_up_button.Name = "manager_sign_up_button";
            manager_sign_up_button.Size = new Size(277, 58);
            manager_sign_up_button.TabIndex = 2;
            manager_sign_up_button.Text = "Manager";
            manager_sign_up_button.UseVisualStyleBackColor = false;
            manager_sign_up_button.Click += manager_sign_up_button_Click;
            // 
            // owner_sign_up_button
            // 
            owner_sign_up_button.AutoSize = true;
            owner_sign_up_button.BackColor = Color.FromArgb(255, 136, 183);
            owner_sign_up_button.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            owner_sign_up_button.FlatAppearance.BorderSize = 0;
            owner_sign_up_button.FlatStyle = FlatStyle.Flat;
            owner_sign_up_button.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            owner_sign_up_button.ForeColor = Color.White;
            owner_sign_up_button.Location = new Point(462, 163);
            owner_sign_up_button.Name = "owner_sign_up_button";
            owner_sign_up_button.Size = new Size(277, 58);
            owner_sign_up_button.TabIndex = 1;
            owner_sign_up_button.Text = "Owner";
            owner_sign_up_button.UseVisualStyleBackColor = false;
            owner_sign_up_button.Click += owner_sign_up_button_Click;
            // 
            // welcome_back
            // 
            welcome_back.AutoSize = true;
            welcome_back.Font = new Font("Dancing Script", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_back.ForeColor = Color.FromArgb(255, 136, 183);
            welcome_back.Location = new Point(300, 9);
            welcome_back.Name = "welcome_back";
            welcome_back.Size = new Size(601, 134);
            welcome_back.TabIndex = 0;
            welcome_back.Text = "Welcome Back!";
            welcome_back.Click += welcome_back_Click;
            // 
            // close_button
            // 
            close_button.BackColor = Color.Transparent;
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Zoom;
            close_button.Cursor = Cursors.Hand;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.ForeColor = Color.Transparent;
            close_button.Location = new Point(1327, 12);
            close_button.Name = "close_button";
            close_button.Size = new Size(52, 39);
            close_button.TabIndex = 4;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // sign_up_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1391, 666);
            Controls.Add(close_button);
            Controls.Add(sign_up_page_panel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "sign_up_main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up";
            Load += sign_up_main_Load;
            sign_up_page_panel.ResumeLayout(false);
            sign_up_page_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sign_up_page_panel;
        private Label welcome_back;
        private Button employee_signUp_button;
        private Button receptionist_sign_up_button;
        private Button manager_sign_up_button;
        private Button owner_sign_up_button;
        private Panel logo_signup_main;
        private Button close_button;
    }
}
