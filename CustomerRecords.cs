using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
namespace mekeceisik_1
{
    public partial class CustomerRecords : Form
    {
        private static DataTable dTable { get; set; }
        private MainPage mainPage;
        public CustomerRecords(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainPage.Show();
            this.Close();

        }

        public void LoadCustomerProcessView()
        {
            // Define the query to get data from the view
            string query = "SELECT * FROM CustomerProcessView";

            // Using the shared connection method from Program.cs
            using (SqlConnection conn = Program.GetOpenConnection())
            {
                try
                {
                    // Create a data adapter to fetch the data
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    // Create a DataTable to hold the data
                    DataTable dt = new DataTable();

                    // Fill the DataTable with the data from the view
                    da.Fill(dt);
                    dTable= dt;

                    // Bind the DataTable to the DataGridView
                    tbl_customerRecords.DataSource = dt;


                    tbl_customerRecords.Columns["CustomerId"].HeaderText = "Müşteri ID";
                    tbl_customerRecords.Columns["Name"].HeaderText = "İsim-Soyisim";
                    tbl_customerRecords.Columns["Phone"].HeaderText = "Telefon";
                    tbl_customerRecords.Columns["Address"].HeaderText = "Adres";
                    tbl_customerRecords.Columns["OliveKg"].HeaderText = "Zeytin Kilo";
                    tbl_customerRecords.Columns["ObtainedOil"].HeaderText = "Elde Edilen Yağ";
                    tbl_customerRecords.Columns["SoldOil"].HeaderText = "Satılan Yağ";
                    tbl_customerRecords.Columns["Price"].HeaderText = "Fiyat";
                    tbl_customerRecords.Columns["Claim"].HeaderText = "Hak";
                    tbl_customerRecords.Columns["Efficiency"].HeaderText = "Verimlilik";
                    tbl_customerRecords.Columns["Package"].HeaderText = "Teneke";
                    tbl_customerRecords.Columns["PurchaseType"].HeaderText = "Ödeme Tipi";
                    tbl_customerRecords.Columns["Date"].HeaderText = "Tarih";
                }
                catch (Exception ex)
                {
                    // Retrieve the line number and method where the exception occurred
                    var lineNumber = new System.Diagnostics.StackTrace(ex, true).GetFrame(0).GetFileLineNumber();
                    var methodName = ex.TargetSite.Name; // Method name where exception occurred
                    var className = ex.TargetSite.DeclaringType.Name; // Class name where exception occurred

                    // Display the information in a MessageBox
                    MessageBox.Show($"Error: {ex.Message}\nClass: {className}\nMethod: {methodName}\nLine: {lineNumber}",
                                    "Exception Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CustomerRecords_Load(object sender, EventArgs e)
        {
            LoadCustomerProcessView();
        }

        public void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath)
        {
            // Create a new workbook
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Customer Data");

                // Add column headers from DataGridView to the Excel sheet
                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = dataGridView.Columns[col].HeaderText;
                }

                // Add rows from DataGridView to the Excel sheet
                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        var cellValue = dataGridView.Rows[row].Cells[col].Value;
                        worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                    }
                }

                // Save the workbook to the specified file path
                workbook.SaveAs(filePath);

                MessageBox.Show("Kayıtlar başarıyla Excel'e aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_exportExcel_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Save as Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                CustomerRecords exporter = new CustomerRecords(mainPage);
                exporter.ExportDataGridViewToExcel(tbl_customerRecords, saveFileDialog.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbl_customerRecords.DataSource = SearchByName(txt_search.Text);

        }

        public DataView SearchByName(string name)
        {
            
            var customerDataTable = dTable;

            // If customerDataTable is null or empty, return to prevent errors
            if (customerDataTable == null || customerDataTable.Rows.Count == 0)
                return new DataView();

            // Create a DataView from the existing DataTable
            DataView dv = customerDataTable.DefaultView;

            // Apply the RowFilter to filter by both Name and Surname columns
            // Filtering to match any part of the Name or Surname (case-insensitive)
            dv.RowFilter = $"(CONVERT(Name, 'System.String') LIKE '%{name.ToLower()}%')";

            // Bind the filtered DataView to the DataGridView

            return dv;

        }
    }
}
