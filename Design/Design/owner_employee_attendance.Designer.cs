namespace Design
{
    partial class owner_employee_attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_employee_attendance));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            status_category = new ComboBox();
            attendence_dataGridView = new DataGridView();
            DELETE_BUTTON = new Button();
            EDIT_BUTTON = new Button();
            ADD_BUTTON = new Button();
            label5 = new Label();
            emp_id = new TextBox();
            label4 = new Label();
            position_category = new ComboBox();
            emp_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendence_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(status_category);
            panel1.Controls.Add(attendence_dataGridView);
            panel1.Controls.Add(DELETE_BUTTON);
            panel1.Controls.Add(EDIT_BUTTON);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(emp_id);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(position_category);
            panel1.Controls.Add(emp_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 245);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(17, 245);
            label3.Name = "label3";
            label3.Size = new Size(76, 29);
            label3.TabIndex = 17;
            label3.Text = "DATE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(575, 152);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 16;
            label1.Text = "STATUS";
            // 
            // status_category
            // 
            status_category.FormattingEnabled = true;
            status_category.Location = new Point(715, 152);
            status_category.Margin = new Padding(3, 4, 3, 4);
            status_category.Name = "status_category";
            status_category.Size = new Size(235, 28);
            status_category.TabIndex = 15;
            status_category.Text = "SELECT";
            // 
            // attendence_dataGridView
            // 
            attendence_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            attendence_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendence_dataGridView.Location = new Point(23, 433);
            attendence_dataGridView.Margin = new Padding(3, 4, 3, 4);
            attendence_dataGridView.Name = "attendence_dataGridView";
            attendence_dataGridView.RowHeadersWidth = 51;
            attendence_dataGridView.Size = new Size(1160, 284);
            attendence_dataGridView.TabIndex = 14;
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
            DELETE_BUTTON.Location = new Point(641, 336);
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
            EDIT_BUTTON.Size = new Size(145, 60);
            EDIT_BUTTON.TabIndex = 11;
            EDIT_BUTTON.Text = "UPDATE";
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
            label5.Location = new Point(17, 148);
            label5.Name = "label5";
            label5.Size = new Size(127, 29);
            label5.TabIndex = 9;
            label5.Text = "POSITION";
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
            label4.Location = new Point(575, 60);
            label4.Name = "label4";
            label4.Size = new Size(37, 29);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // position_category
            // 
            position_category.FormattingEnabled = true;
            position_category.Location = new Point(158, 149);
            position_category.Margin = new Padding(3, 4, 3, 4);
            position_category.Name = "position_category";
            position_category.Size = new Size(235, 28);
            position_category.TabIndex = 6;
            position_category.Text = "SELECT";
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
            // owner_employee_attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "owner_employee_attendance";
            Text = "owner_employee_attendance";
            Load += owner_employee_attendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendence_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView attendence_dataGridView;
        private Button DELETE_BUTTON;
        private Button EDIT_BUTTON;
        private Button ADD_BUTTON;
        private Label label5;
        private TextBox emp_id;
        private Label label4;
        private ComboBox position_category;
        private TextBox emp_name;
        private Label label2;
        private Label label1;
        private ComboBox status_category;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}