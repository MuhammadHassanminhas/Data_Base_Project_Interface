namespace Design
{
    partial class manager_tips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_tips));
            panel1 = new Panel();
            amount_tip = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            TIP_dataGridView = new DataGridView();
            DELETE_BUTTON = new Button();
            EDIT_BUTTON = new Button();
            ADD_BUTTON = new Button();
            label5 = new Label();
            emp_id = new TextBox();
            label4 = new Label();
            service_category = new ComboBox();
            emp_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TIP_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(amount_tip);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TIP_dataGridView);
            panel1.Controls.Add(DELETE_BUTTON);
            panel1.Controls.Add(EDIT_BUTTON);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(emp_id);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(service_category);
            panel1.Controls.Add(emp_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 3;
            // 
            // amount_tip
            // 
            amount_tip.Location = new Point(158, 240);
            amount_tip.Margin = new Padding(3, 4, 3, 4);
            amount_tip.Name = "amount_tip";
            amount_tip.Size = new Size(235, 27);
            amount_tip.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(16, 240);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 19;
            label1.Text = "AMOUNT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(715, 145);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(581, 145);
            label3.Name = "label3";
            label3.Size = new Size(76, 29);
            label3.TabIndex = 17;
            label3.Text = "DATE";
            // 
            // TIP_dataGridView
            // 
            TIP_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            TIP_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TIP_dataGridView.Location = new Point(23, 433);
            TIP_dataGridView.Margin = new Padding(3, 4, 3, 4);
            TIP_dataGridView.Name = "TIP_dataGridView";
            TIP_dataGridView.RowHeadersWidth = 51;
            TIP_dataGridView.Size = new Size(1160, 284);
            TIP_dataGridView.TabIndex = 14;
            // 
            // DELETE_BUTTON
            // 
            DELETE_BUTTON.AutoSize = true;
            DELETE_BUTTON.BackColor = Color.FromArgb(255, 136, 183);
            DELETE_BUTTON.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            DELETE_BUTTON.FlatAppearance.BorderSize = 0;
            DELETE_BUTTON.FlatStyle = FlatStyle.Flat;
            DELETE_BUTTON.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DELETE_BUTTON.ForeColor = Color.White;
            DELETE_BUTTON.Location = new Point(614, 336);
            DELETE_BUTTON.Margin = new Padding(3, 4, 3, 4);
            DELETE_BUTTON.Name = "DELETE_BUTTON";
            DELETE_BUTTON.Size = new Size(163, 60);
            DELETE_BUTTON.TabIndex = 12;
            DELETE_BUTTON.Text = "DELETE";
            DELETE_BUTTON.UseVisualStyleBackColor = false;
            DELETE_BUTTON.Click += DELETE_BUTTON_Click;
            // 
            // EDIT_BUTTON
            // 
            EDIT_BUTTON.AutoSize = true;
            EDIT_BUTTON.BackColor = Color.FromArgb(255, 136, 183);
            EDIT_BUTTON.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            EDIT_BUTTON.FlatAppearance.BorderSize = 0;
            EDIT_BUTTON.FlatStyle = FlatStyle.Flat;
            EDIT_BUTTON.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EDIT_BUTTON.ForeColor = Color.White;
            EDIT_BUTTON.Location = new Point(490, 336);
            EDIT_BUTTON.Margin = new Padding(3, 4, 3, 4);
            EDIT_BUTTON.Name = "EDIT_BUTTON";
            EDIT_BUTTON.Size = new Size(117, 60);
            EDIT_BUTTON.TabIndex = 11;
            EDIT_BUTTON.Text = "SAVE";
            EDIT_BUTTON.UseVisualStyleBackColor = false;
            EDIT_BUTTON.Click += EDIT_BUTTON_Click;
            // 
            // ADD_BUTTON
            // 
            ADD_BUTTON.AutoSize = true;
            ADD_BUTTON.BackColor = Color.FromArgb(255, 136, 183);
            ADD_BUTTON.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            ADD_BUTTON.FlatAppearance.BorderSize = 0;
            ADD_BUTTON.FlatStyle = FlatStyle.Flat;
            ADD_BUTTON.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ADD_BUTTON.ForeColor = Color.White;
            ADD_BUTTON.Location = new Point(367, 336);
            ADD_BUTTON.Margin = new Padding(3, 4, 3, 4);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(117, 60);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "ADD";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            ADD_BUTTON.Click += ADD_BUTTON_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 136, 183);
            label5.Location = new Point(17, 151);
            label5.Name = "label5";
            label5.Size = new Size(118, 29);
            label5.TabIndex = 9;
            label5.Text = "SERVICE";
            // 
            // emp_id
            // 
            emp_id.Location = new Point(715, 60);
            emp_id.Margin = new Padding(3, 4, 3, 4);
            emp_id.Name = "emp_id";
            emp_id.Size = new Size(235, 27);
            emp_id.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(574, 60);
            label4.Name = "label4";
            label4.Size = new Size(37, 29);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // service_category
            // 
            service_category.FormattingEnabled = true;
            service_category.Location = new Point(158, 149);
            service_category.Margin = new Padding(3, 4, 3, 4);
            service_category.Name = "service_category";
            service_category.Size = new Size(235, 28);
            service_category.TabIndex = 6;
            service_category.Text = "SELECT";
            // 
            // emp_name
            // 
            emp_name.Location = new Point(158, 56);
            emp_name.Margin = new Padding(3, 4, 3, 4);
            emp_name.Name = "emp_name";
            emp_name.Size = new Size(235, 27);
            emp_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(17, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // manager_tips
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "manager_tips";
            Text = "manager_tips";
            Load += manager_tips_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TIP_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DataGridView TIP_dataGridView;
        private Button DELETE_BUTTON;
        private Button EDIT_BUTTON;
        private Button ADD_BUTTON;
        private Label label5;
        private TextBox emp_id;
        private Label label4;
        private ComboBox service_category;
        private TextBox emp_name;
        private Label label2;
        private TextBox amount_tip;
        private Label label1;
    }
}