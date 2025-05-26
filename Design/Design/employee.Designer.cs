namespace Design
{
    partial class employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            panel1 = new Panel();
            label2 = new Label();
            show_button = new Button();
            textBox_employee_password = new TextBox();
            hide_button = new Button();
            enterloginid = new Label();
            Employee_ID = new TextBox();
            owner_login_up_button = new Button();
            panel2 = new Panel();
            label1 = new Label();
            back_button = new Button();
            close_button = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(show_button);
            panel1.Controls.Add(textBox_employee_password);
            panel1.Controls.Add(hide_button);
            panel1.Controls.Add(enterloginid);
            panel1.Controls.Add(Employee_ID);
            panel1.Controls.Add(owner_login_up_button);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(421, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 610);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 420);
            label2.Name = "label2";
            label2.Size = new Size(200, 22);
            label2.TabIndex = 15;
            label2.Text = "Enter Login Password";
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
            show_button.Location = new Point(432, 445);
            show_button.Name = "show_button";
            show_button.Size = new Size(33, 39);
            show_button.TabIndex = 14;
            show_button.UseVisualStyleBackColor = false;
            show_button.Click += show_button_Click;
            // 
            // textBox_employee_password
            // 
            textBox_employee_password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_employee_password.Location = new Point(122, 445);
            textBox_employee_password.Name = "textBox_employee_password";
            textBox_employee_password.PasswordChar = '*';
            textBox_employee_password.Size = new Size(305, 39);
            textBox_employee_password.TabIndex = 13;
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
            hide_button.Location = new Point(433, 445);
            hide_button.Name = "hide_button";
            hide_button.Size = new Size(33, 39);
            hide_button.TabIndex = 12;
            hide_button.UseVisualStyleBackColor = false;
            hide_button.Click += hide_button_Click;
            // 
            // enterloginid
            // 
            enterloginid.AutoSize = true;
            enterloginid.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterloginid.Location = new Point(122, 332);
            enterloginid.Name = "enterloginid";
            enterloginid.Size = new Size(134, 22);
            enterloginid.TabIndex = 9;
            enterloginid.Text = "Enter Login ID";
            // 
            // Employee_ID
            // 
            Employee_ID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Employee_ID.Location = new Point(122, 370);
            Employee_ID.Name = "Employee_ID";
            Employee_ID.Size = new Size(305, 39);
            Employee_ID.TabIndex = 8;
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
            owner_login_up_button.Location = new Point(140, 544);
            owner_login_up_button.Name = "owner_login_up_button";
            owner_login_up_button.Size = new Size(269, 48);
            owner_login_up_button.TabIndex = 7;
            owner_login_up_button.Text = "Login";
            owner_login_up_button.UseVisualStyleBackColor = false;
            owner_login_up_button.Click += owner_login_up_button_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(84, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 289);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(4, 116);
            label1.Name = "label1";
            label1.Size = new Size(373, 57);
            label1.TabIndex = 0;
            label1.Text = "Employee Login";
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
            back_button.TabIndex = 2;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
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
            close_button.TabIndex = 3;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1391, 666);
            Controls.Add(close_button);
            Controls.Add(back_button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employee";
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
        private Button back_button;
        private Button owner_login_up_button;
        private TextBox Employee_ID;
        private Label enterloginid;
        private Button hide_button;
        private TextBox textBox_employee_password;
        private Button show_button;
        private Label label2;
        private Button close_button;
    }
}