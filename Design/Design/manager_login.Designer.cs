namespace Design
{
    partial class manager_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_login));
            panel1 = new Panel();
            show_button = new Button();
            hide_button = new Button();
            owner_login_up_button = new Button();
            label2 = new Label();
            enterloginpassword = new Label();
            textBox_login_password = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
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
            panel1.Controls.Add(owner_login_up_button);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(enterloginpassword);
            panel1.Controls.Add(textBox_login_password);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(421, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 610);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // show_button
            // 
            show_button.BackColor = Color.Transparent;
            show_button.BackgroundImage = (Image)resources.GetObject("show_button.BackgroundImage");
            show_button.BackgroundImageLayout = ImageLayout.Zoom;
            show_button.FlatAppearance.BorderSize = 0;
            show_button.FlatStyle = FlatStyle.Flat;
            show_button.Location = new Point(433, 352);
            show_button.Name = "show_button";
            show_button.Size = new Size(33, 39);
            show_button.TabIndex = 9;
            show_button.UseVisualStyleBackColor = false;
            show_button.Click += show_button_Click;
            // 
            // hide_button
            // 
            hide_button.BackColor = Color.Transparent;
            hide_button.BackgroundImage = (Image)resources.GetObject("hide_button.BackgroundImage");
            hide_button.BackgroundImageLayout = ImageLayout.Zoom;
            hide_button.FlatAppearance.BorderSize = 0;
            hide_button.FlatStyle = FlatStyle.Flat;
            hide_button.Location = new Point(433, 352);
            hide_button.Name = "hide_button";
            hide_button.Size = new Size(33, 39);
            hide_button.TabIndex = 8;
            hide_button.UseVisualStyleBackColor = false;
            hide_button.Click += hide_button_Click;
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
            owner_login_up_button.Location = new Point(140, 527);
            owner_login_up_button.Name = "owner_login_up_button";
            owner_login_up_button.Size = new Size(269, 48);
            owner_login_up_button.TabIndex = 7;
            owner_login_up_button.Text = "Login";
            owner_login_up_button.UseVisualStyleBackColor = false;
            owner_login_up_button.Click += owner_login_up_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(198, 466);
            label2.Name = "label2";
            label2.Size = new Size(153, 22);
            label2.TabIndex = 6;
            label2.Text = "Forgot Password?";
            // 
            // enterloginpassword
            // 
            enterloginpassword.AutoSize = true;
            enterloginpassword.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterloginpassword.Location = new Point(174, 418);
            enterloginpassword.Name = "enterloginpassword";
            enterloginpassword.Size = new Size(200, 22);
            enterloginpassword.TabIndex = 4;
            enterloginpassword.Text = "Enter Login Password";
            // 
            // textBox_login_password
            // 
            textBox_login_password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_login_password.Location = new Point(122, 352);
            textBox_login_password.Name = "textBox_login_password";
            textBox_login_password.PasswordChar = '*';
            textBox_login_password.Size = new Size(305, 39);
            textBox_login_password.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(43, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 289);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(55, 116);
            label1.Name = "label1";
            label1.Size = new Size(352, 57);
            label1.TabIndex = 1;
            label1.Text = "Manager Login";
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
            back_button.TabIndex = 8;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // manager_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1391, 666);
            Controls.Add(back_button);
            Controls.Add(panel1);
            Name = "manager_login";
            Text = "manager_login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox_login_password;
        private Label enterloginpassword;
        private Label label2;
        private Button owner_login_up_button;
        private Button back_button;
        private Button hide_button;
        private Button show_button;
    }
}