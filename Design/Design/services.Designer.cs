namespace Design
{
    partial class services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
            panel1 = new Panel();
            service_id = new TextBox();
            label3 = new Label();
            SERVICE_dataGridView = new DataGridView();
            DELETE_BUTTON = new Button();
            EDIT_BUTTON = new Button();
            ADD_BUTTON = new Button();
            service_price = new TextBox();
            label4 = new Label();
            service_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SERVICE_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(service_id);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SERVICE_dataGridView);
            panel1.Controls.Add(DELETE_BUTTON);
            panel1.Controls.Add(EDIT_BUTTON);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(service_price);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(service_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // service_id
            // 
            service_id.Location = new Point(156, 210);
            service_id.Margin = new Padding(3, 4, 3, 4);
            service_id.Name = "service_id";
            service_id.Size = new Size(235, 27);
            service_id.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(16, 210);
            label3.Name = "label3";
            label3.Size = new Size(37, 29);
            label3.TabIndex = 17;
            label3.Text = "ID";
            // 
            // SERVICE_dataGridView
            // 
            SERVICE_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            SERVICE_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SERVICE_dataGridView.Location = new Point(466, 35);
            SERVICE_dataGridView.Margin = new Padding(3, 4, 3, 4);
            SERVICE_dataGridView.Name = "SERVICE_dataGridView";
            SERVICE_dataGridView.RowHeadersWidth = 51;
            SERVICE_dataGridView.Size = new Size(717, 659);
            SERVICE_dataGridView.TabIndex = 14;
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
            DELETE_BUTTON.Location = new Point(263, 387);
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
            EDIT_BUTTON.Location = new Point(139, 387);
            EDIT_BUTTON.Margin = new Padding(3, 4, 3, 4);
            EDIT_BUTTON.Name = "EDIT_BUTTON";
            EDIT_BUTTON.Size = new Size(117, 60);
            EDIT_BUTTON.TabIndex = 11;
            EDIT_BUTTON.Text = "EDIT";
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
            ADD_BUTTON.Location = new Point(16, 387);
            ADD_BUTTON.Margin = new Padding(3, 4, 3, 4);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(117, 60);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "ADD";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            ADD_BUTTON.Click += ADD_BUTTON_Click;
            // 
            // service_price
            // 
            service_price.Location = new Point(157, 312);
            service_price.Margin = new Padding(3, 4, 3, 4);
            service_price.Name = "service_price";
            service_price.Size = new Size(235, 27);
            service_price.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(14, 312);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 7;
            label4.Text = "PRICE";
            // 
            // service_name
            // 
            service_name.Location = new Point(156, 252);
            service_name.Margin = new Padding(3, 4, 3, 4);
            service_name.Name = "service_name";
            service_name.Size = new Size(235, 27);
            service_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(14, 252);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "services";
            Text = "services";
            Load += services_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SERVICE_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView SERVICE_dataGridView;
        private Button DELETE_BUTTON;
        private Button EDIT_BUTTON;
        private Button ADD_BUTTON;
        private TextBox service_price;
        private Label label4;
        private TextBox service_name;
        private Label label2;
        private TextBox service_id;
        private Label label3;
    }
}