using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Design
{
    public partial class recdeptionist_generate_bill : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private string connStr = "server=localhost;user id=root;password=root;database=beauty_salon";
        public recdeptionist_generate_bill()
        {
            InitializeComponent();
            LoadAppointments(); // Load all appointments on form load
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.CellClick += dgvAppointments_CellClick;
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string billText = GenerateBillText();

            // Set font and layout
            Font printFont = new Font("Courier New", 12);  // Courier for fixed-width alignment
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float lineHeight = printFont.GetHeight(e.Graphics);

            // Split bill text by lines
            string[] lines = billText.Split('\n');
            float yPos = topMargin;

            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
            }
        }
        private void generate_bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void recdeptionist_generate_bill_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }
        private void LoadAppointments(string customerName = "")
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string storedProc = string.IsNullOrEmpty(customerName)
                    ? "sp_AppointmentViewAll"
                    : "sp_AppointmentSearchByName";

                using MySqlCommand cmd = new MySqlCommand(storedProc, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (!string.IsNullOrEmpty(customerName))
                {
                    cmd.Parameters.AddWithValue("@custName", customerName);
                }

                using MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Set DataGridView data source
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row clicks

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Update these to match your column names
            name.Text = row.Cells["ClientName"].Value?.ToString();
            contact.Text = row.Cells["Contact_Number"].Value?.ToString();
            tip.Text = row.Cells["Tip"].Value?.ToString();
            total_price.Text = row.Cells["Price"].Value?.ToString();            // Assuming you have a textbox named 'price'
        }
        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            string searchName = name.Text.Trim();
            LoadAppointments(searchName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
        private string GenerateBillText()
        {
            return
                "====================================\n" +
                "          BEAUTY SALON BILL          \n" +
                "====================================\n" +
                $"Customer Name : {name.Text}\n" +
                $"Contact Number: {contact.Text}\n" +
                $"Tip           : Rs.{tip.Text}\n" +
                $"Total Price   : Rs.{total_price.Text}\n" +
                "====================================\n" +
                "        Thank you for your visit!   \n" +
                "====================================";
        }
    }
}
