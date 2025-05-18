namespace Design
{
    partial class receptionist_view_client_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receptionist_view_client_data));
            panel1 = new Panel();
            client_dataGridView = new DataGridView();
            ADD_BUTTON = new Button();
            contact = new TextBox();
            label4 = new Label();
            name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)client_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(client_dataGridView);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(contact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 5;
            // 
            // client_dataGridView
            // 
            client_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            client_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            client_dataGridView.Location = new Point(23, 259);
            client_dataGridView.Margin = new Padding(3, 4, 3, 4);
            client_dataGridView.Name = "client_dataGridView";
            client_dataGridView.RowHeadersWidth = 51;
            client_dataGridView.Size = new Size(1160, 458);
            client_dataGridView.TabIndex = 14;
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
            ADD_BUTTON.Location = new Point(938, 45);
            ADD_BUTTON.Margin = new Padding(3, 4, 3, 4);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(171, 60);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "SEARCH";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            ADD_BUTTON.Click += ADD_BUTTON_Click;
            // 
            // contact
            // 
            contact.Location = new Point(666, 56);
            contact.Margin = new Padding(3, 4, 3, 4);
            contact.Name = "contact";
            contact.Size = new Size(235, 27);
            contact.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(406, 56);
            label4.Name = "label4";
            label4.Size = new Size(239, 29);
            label4.TabIndex = 7;
            label4.Text = "CONTACT NUMBER";
            // 
            // name
            // 
            name.Location = new Point(144, 52);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(235, 27);
            name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(42, 52);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // receptionist_view_client_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "receptionist_view_client_data";
            Text = "receptionist_view_client_data";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)client_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView attendence_dataGridView;
        private Button ADD_BUTTON;
        private TextBox service_price;
        private Label label4;
        private TextBox service_name;
        private Label label2;
        private TextBox contact;
        private TextBox name;
        private DataGridView client_dataGridView;
    }
}