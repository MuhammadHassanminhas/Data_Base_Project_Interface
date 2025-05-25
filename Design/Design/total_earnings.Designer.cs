using System.Security.Cryptography.Xml;

namespace Design
{
    partial class total_earnings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(total_earnings));
            panel = new Panel();
            net_income = new Label();
            revenue = new Label();
            salary = new Label();
            total_services = new Label();
            tips = new Label();
            display = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(net_income);
            panel.Controls.Add(revenue);
            panel.Controls.Add(salary);
            panel.Controls.Add(total_services);
            panel.Controls.Add(tips);
            panel.Controls.Add(display);
            panel.Controls.Add(dateTimePicker1);
            panel.Controls.Add(label4);
            panel.Controls.Add(label8);
            panel.Controls.Add(label9);
            panel.Controls.Add(label6);
            panel.Controls.Add(label3);
            panel.Controls.Add(label2);
            panel.Location = new Point(24, 183);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(1206, 419);
            panel.TabIndex = 1;
            // 
            // net_income
            // 
            net_income.AutoSize = true;
            net_income.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            net_income.ForeColor = Color.FromArgb(0, 0, 0);
            net_income.Location = new Point(874, 285);
            net_income.Name = "net_income";
            net_income.Size = new Size(0, 31);
            net_income.TabIndex = 32;
            // 
            // revenue
            // 
            revenue.AutoSize = true;
            revenue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            revenue.ForeColor = Color.FromArgb(0, 0, 0);
            revenue.Location = new Point(311, 285);
            revenue.Name = "revenue";
            revenue.Size = new Size(0, 31);
            revenue.TabIndex = 31;
            // 
            // salary
            // 
            salary.AutoSize = true;
            salary.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary.ForeColor = Color.FromArgb(0, 0, 0);
            salary.Location = new Point(983, 155);
            salary.Name = "salary";
            salary.Size = new Size(0, 31);
            salary.TabIndex = 30;
            // 
            // total_services
            // 
            total_services.AutoSize = true;
            total_services.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_services.ForeColor = Color.FromArgb(0, 0, 0);
            total_services.Location = new Point(436, 155);
            total_services.Name = "total_services";
            total_services.Size = new Size(0, 31);
            total_services.TabIndex = 29;
            // 
            // tips
            // 
            tips.AutoSize = true;
            tips.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tips.ForeColor = Color.FromArgb(0, 0, 0);
            tips.Location = new Point(845, 42);
            tips.Name = "tips";
            tips.Size = new Size(0, 31);
            tips.TabIndex = 28;
            // 
            // display
            // 
            display.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            display.ForeColor = Color.FromArgb(0, 0, 0);
            display.Location = new Point(542, 362);
            display.Name = "display";
            display.Size = new Size(155, 36);
            display.TabIndex = 27;
            display.Text = "Display Data";
            display.UseVisualStyleBackColor = true;
            display.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 39);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(694, 287);
            label4.Name = "label4";
            label4.Size = new Size(164, 29);
            label4.TabIndex = 25;
            label4.Text = "NET INCOME";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 136, 183);
            label8.Location = new Point(54, 39);
            label8.Name = "label8";
            label8.Size = new Size(101, 29);
            label8.TabIndex = 18;
            label8.Text = "MONTH";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 136, 183);
            label9.Location = new Point(694, 157);
            label9.Name = "label9";
            label9.Size = new Size(274, 29);
            label9.TabIndex = 16;
            label9.Text = "EMPLOYEE SALARIES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 136, 183);
            label6.Location = new Point(54, 287);
            label6.Name = "label6";
            label6.Size = new Size(240, 29);
            label6.TabIndex = 10;
            label6.Text = "SERVICE REVENUE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(716, 44);
            label3.Name = "label3";
            label3.Size = new Size(67, 29);
            label3.TabIndex = 8;
            label3.Text = "TIPS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(54, 157);
            label2.Name = "label2";
            label2.Size = new Size(370, 29);
            label2.TabIndex = 4;
            label2.Text = "TOTAL SERVICES PER MONTH";
            label2.Click += label2_Click;
            // 
            // total_earnings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "total_earnings";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button display;
        private Label tips;
        private Label net_income;
        private Label revenue;
        private Label salary;
        private Label total_services;
    }
}