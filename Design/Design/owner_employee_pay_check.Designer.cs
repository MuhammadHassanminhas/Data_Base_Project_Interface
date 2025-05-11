namespace Design
{
    partial class owner_employee_pay_check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_employee_pay_check));
            panel1 = new Panel();
            netsalary = new Label();
            deduction = new Label();
            tips = new Label();
            absents = new Label();
            salaryperday = new Label();
            name = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            CALCULATE = new Button();
            RELEASE_BUTTON = new Button();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(netsalary);
            panel1.Controls.Add(deduction);
            panel1.Controls.Add(tips);
            panel1.Controls.Add(absents);
            panel1.Controls.Add(salaryperday);
            panel1.Controls.Add(name);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CALCULATE);
            panel1.Controls.Add(RELEASE_BUTTON);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(id);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // netsalary
            // 
            netsalary.AutoSize = true;
            netsalary.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            netsalary.Location = new Point(942, 379);
            netsalary.Name = "netsalary";
            netsalary.Size = new Size(0, 31);
            netsalary.TabIndex = 32;
            // 
            // deduction
            // 
            deduction.AutoSize = true;
            deduction.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deduction.Location = new Point(931, 225);
            deduction.Name = "deduction";
            deduction.Size = new Size(0, 31);
            deduction.TabIndex = 31;
            // 
            // tips
            // 
            tips.AutoSize = true;
            tips.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tips.Location = new Point(491, 224);
            tips.Name = "tips";
            tips.Size = new Size(0, 31);
            tips.TabIndex = 30;
            // 
            // absents
            // 
            absents.AutoSize = true;
            absents.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            absents.Location = new Point(155, 222);
            absents.Name = "absents";
            absents.Size = new Size(0, 31);
            absents.TabIndex = 29;
            // 
            // salaryperday
            // 
            salaryperday.AutoSize = true;
            salaryperday.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryperday.Location = new Point(962, 39);
            salaryperday.Name = "salaryperday";
            salaryperday.Size = new Size(0, 31);
            salaryperday.TabIndex = 28;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(515, 40);
            name.Name = "name";
            name.Size = new Size(0, 31);
            name.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(206, 377);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(767, 379);
            label4.Name = "label4";
            label4.Size = new Size(164, 29);
            label4.TabIndex = 25;
            label4.Text = "NET SALARY";
            // 
            // CALCULATE
            // 
            CALCULATE.AutoSize = true;
            CALCULATE.BackColor = Color.FromArgb(255, 136, 183);
            CALCULATE.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            CALCULATE.FlatAppearance.BorderSize = 0;
            CALCULATE.FlatStyle = FlatStyle.Flat;
            CALCULATE.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CALCULATE.ForeColor = Color.White;
            CALCULATE.Location = new Point(27, 525);
            CALCULATE.Margin = new Padding(3, 4, 3, 4);
            CALCULATE.Name = "CALCULATE";
            CALCULATE.Size = new Size(229, 60);
            CALCULATE.TabIndex = 23;
            CALCULATE.Text = "CALCULATE";
            CALCULATE.UseVisualStyleBackColor = false;
            CALCULATE.Click += button1_Click;
            // 
            // RELEASE_BUTTON
            // 
            RELEASE_BUTTON.AutoSize = true;
            RELEASE_BUTTON.BackColor = Color.FromArgb(255, 136, 183);
            RELEASE_BUTTON.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            RELEASE_BUTTON.FlatAppearance.BorderSize = 0;
            RELEASE_BUTTON.FlatStyle = FlatStyle.Flat;
            RELEASE_BUTTON.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RELEASE_BUTTON.ForeColor = Color.White;
            RELEASE_BUTTON.Location = new Point(262, 525);
            RELEASE_BUTTON.Margin = new Padding(3, 4, 3, 4);
            RELEASE_BUTTON.Name = "RELEASE_BUTTON";
            RELEASE_BUTTON.Size = new Size(186, 60);
            RELEASE_BUTTON.TabIndex = 22;
            RELEASE_BUTTON.Text = "RELEASE";
            RELEASE_BUTTON.UseVisualStyleBackColor = false;
            RELEASE_BUTTON.Click += ADD_BUTTON_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 136, 183);
            label8.Location = new Point(27, 377);
            label8.Name = "label8";
            label8.Size = new Size(173, 29);
            label8.TabIndex = 18;
            label8.Text = "MONTH/YEAR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 136, 183);
            label9.Location = new Point(767, 225);
            label9.Name = "label9";
            label9.Size = new Size(154, 29);
            label9.TabIndex = 16;
            label9.Text = "DEDUCTION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 136, 183);
            label5.Location = new Point(418, 225);
            label5.Name = "label5";
            label5.Size = new Size(67, 29);
            label5.TabIndex = 12;
            label5.Text = "TIPS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 136, 183);
            label6.Location = new Point(27, 224);
            label6.Name = "label6";
            label6.Size = new Size(111, 29);
            label6.TabIndex = 10;
            label6.Text = "ABSENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(723, 41);
            label3.Name = "label3";
            label3.Size = new Size(219, 29);
            label3.TabIndex = 8;
            label3.Text = "SALARY PER DAY";
            // 
            // id
            // 
            id.Location = new Point(82, 37);
            id.Margin = new Padding(3, 4, 3, 4);
            id.Name = "id";
            id.Size = new Size(235, 27);
            id.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(27, 39);
            label1.Name = "label1";
            label1.Size = new Size(37, 29);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(418, 41);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 4;
            label2.Text = "NAME";
            // 
            // owner_employee_pay_check
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "owner_employee_pay_check";
            Text = "owner_employee_pay_check";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox id;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label6;
        private Button CALCULATE;
        private Button RELEASE_BUTTON;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label netsalary;
        private Label deduction;
        private Label tips;
        private Label absents;
        private Label salaryperday;
        private Label name;
    }
}