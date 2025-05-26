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
            emp_password = new TextBox();
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
            panel1.Controls.Add(emp_password);
            panel1.Controls.Add(hide_button);
            panel1.Controls.Add(enterloginid);
            panel1.Controls.Add(Employee_ID);
            panel1.Controls.Add(owner_login_up_button);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(481, 37);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 813);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 560);
            label2.Name = "label2";
            label2.Size = new Size(250, 28);
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
            show_button.Location = new Point(494, 593);
            show_button.Margin = new Padding(3, 4, 3, 4);
            show_button.Name = "show_button";
            show_button.Size = new Size(38, 52);
            show_button.TabIndex = 14;
            show_button.UseVisualStyleBackColor = false;
            show_button.Click += show_button_Click;
            // 
            // emp_password
            // 
            emp_password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_password.Location = new Point(139, 593);
            emp_password.Margin = new Padding(3, 4, 3, 4);
            emp_password.Name = "emp_password";
            emp_password.PasswordChar = '*';
            emp_password.Size = new Size(348, 47);
            emp_password.TabIndex = 13;
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
            hide_button.Location = new Point(495, 593);
            hide_button.Margin = new Padding(3, 4, 3, 4);
            hide_button.Name = "hide_button";
            hide_button.Size = new Size(38, 52);
            hide_button.TabIndex = 12;
            hide_button.UseVisualStyleBackColor = false;
            hide_button.Click += hide_button_Click;
            // 
            // enterloginid
            // 
            enterloginid.AutoSize = true;
            enterloginid.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterloginid.Location = new Point(139, 441);
            enterloginid.Name = "enterloginid";
            enterloginid.Size = new Size(169, 28);
            enterloginid.TabIndex = 9;
            enterloginid.Text = "Enter Login ID";
            // 
            // Employee_ID
            // 
            Employee_ID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Employee_ID.Location = new Point(139, 493);
            Employee_ID.Margin = new Padding(3, 4, 3, 4);
            Employee_ID.Name = "Employee_ID";
            Employee_ID.Size = new Size(348, 47);
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
            owner_login_up_button.Location = new Point(139, 704);
            owner_login_up_button.Margin = new Padding(3, 4, 3, 4);
            owner_login_up_button.Name = "owner_login_up_button";
            owner_login_up_button.Size = new Size(348, 73);
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
            panel2.Location = new Point(96, 33);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 385);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(-12, 155);
            label1.Name = "label1";
            label1.Size = new Size(465, 70);
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
            back_button.Location = new Point(14, 16);
            back_button.Margin = new Padding(3, 4, 3, 4);
            back_button.Name = "back_button";
            back_button.Size = new Size(42, 52);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
<<<<<<< HEAD
            ClientSize = new Size(1391, 666);
            Controls.Add(close_button);
            Controls.Add(back_button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
=======
            ClientSize = new Size(1590, 888);
            Controls.Add(back_button);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
>>>>>>> e9c65780ba084b63cf9f3c2eb1cc713377add089
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
        private TextBox emp_password;
        private Button show_button;
        private Label label2;
        private Button close_button;
    }
}