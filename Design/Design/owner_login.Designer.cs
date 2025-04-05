namespace Design
{
    partial class owner_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_login));
            panel1 = new Panel();
            show_button = new Button();
            hide_button = new Button();
            label1 = new Label();
            owner_login_up_button = new Button();
            enterloginpassword = new Label();
            textBox_login_password = new TextBox();
            panel2 = new Panel();
            owner_heading_main = new Label();
            back_button = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(show_button);
            panel1.Controls.Add(hide_button);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(owner_login_up_button);
            panel1.Controls.Add(enterloginpassword);
            panel1.Controls.Add(textBox_login_password);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(421, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 610);
            panel1.TabIndex = 0;
            // 
            // show_button
            // 
            show_button.BackColor = Color.Transparent;
            show_button.BackgroundImage = (Image)resources.GetObject("show_button.BackgroundImage");
            show_button.BackgroundImageLayout = ImageLayout.Zoom;
            show_button.FlatAppearance.BorderSize = 0;
            show_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            show_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            show_button.FlatStyle = FlatStyle.Flat;
            show_button.Location = new Point(433, 342);
            show_button.Name = "show_button";
            show_button.Size = new Size(33, 39);
            show_button.TabIndex = 7;
            show_button.UseVisualStyleBackColor = false;
            show_button.Click += show_button_Click;
            // 
            // hide_button
            // 
            hide_button.BackColor = Color.Transparent;
            hide_button.BackgroundImage = (Image)resources.GetObject("hide_button.BackgroundImage");
            hide_button.BackgroundImageLayout = ImageLayout.Zoom;
            hide_button.FlatAppearance.BorderSize = 0;
            hide_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hide_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hide_button.FlatStyle = FlatStyle.Flat;
            hide_button.Location = new Point(433, 342);
            hide_button.Name = "hide_button";
            hide_button.Size = new Size(33, 39);
            hide_button.TabIndex = 6;
            hide_button.UseVisualStyleBackColor = false;
            hide_button.Click += hide_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(198, 446);
            label1.Name = "label1";
            label1.Size = new Size(153, 22);
            label1.TabIndex = 5;
            label1.Text = "Forgot Password?";
            // 
            // owner_login_up_button
            // 
            owner_login_up_button.AutoSize = true;
            owner_login_up_button.BackColor = Color.FromArgb(255, 136, 183);
            owner_login_up_button.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            owner_login_up_button.FlatAppearance.BorderSize = 0;
            owner_login_up_button.FlatStyle = FlatStyle.Flat;
            owner_login_up_button.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            owner_login_up_button.ForeColor = Color.White;
            owner_login_up_button.Location = new Point(140, 517);
            owner_login_up_button.Name = "owner_login_up_button";
            owner_login_up_button.Size = new Size(269, 48);
            owner_login_up_button.TabIndex = 4;
            owner_login_up_button.Text = "Login";
            owner_login_up_button.UseVisualStyleBackColor = false;
            owner_login_up_button.Click += owner_login_up_button_Click;
            // 
            // enterloginpassword
            // 
            enterloginpassword.AutoSize = true;
            enterloginpassword.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterloginpassword.Location = new Point(174, 399);
            enterloginpassword.Name = "enterloginpassword";
            enterloginpassword.Size = new Size(200, 22);
            enterloginpassword.TabIndex = 3;
            enterloginpassword.Text = "Enter Login Password";
            // 
            // textBox_login_password
            // 
            textBox_login_password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_login_password.Location = new Point(122, 342);
            textBox_login_password.Name = "textBox_login_password";
            textBox_login_password.PasswordChar = '*';
            textBox_login_password.Size = new Size(305, 39);
            textBox_login_password.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(owner_heading_main);
            panel2.Location = new Point(84, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 289);
            panel2.TabIndex = 1;
            // 
            // owner_heading_main
            // 
            owner_heading_main.AutoSize = true;
            owner_heading_main.BackColor = Color.Transparent;
            owner_heading_main.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            owner_heading_main.ForeColor = Color.FromArgb(255, 136, 183);
            owner_heading_main.Location = new Point(38, 129);
            owner_heading_main.Name = "owner_heading_main";
            owner_heading_main.Size = new Size(305, 57);
            owner_heading_main.TabIndex = 0;
            owner_heading_main.Text = "Owner Login";
            owner_heading_main.Click += label1_Click;
            // 
            // back_button
            // 
            back_button.BackColor = Color.Transparent;
            back_button.BackgroundImage = (Image)resources.GetObject("back_button.BackgroundImage");
            back_button.BackgroundImageLayout = ImageLayout.Center;
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            back_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.ForeColor = Color.Transparent;
            back_button.Location = new Point(12, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(37, 39);
            back_button.TabIndex = 1;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += button1_Click;
            // 
            // owner_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1391, 666);
            Controls.Add(back_button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "owner_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "owner_login";
            Load += owner_login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label owner_heading_main;
        private Panel panel2;
        private Label enterloginpassword;
        private TextBox textBox_login_password;
        private Button owner_login_up_button;
        private Label label1;
        private Button back_button;
        private Button show_button;
        private Button hide_button;
    }
}