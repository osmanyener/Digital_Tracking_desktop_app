using System;
using System.Data;
using System.Data.SqlClient;
using ClosedXML.Excel;
using mekeceisik_1;


namespace mekeceisik_1 {
     internal class ExcelToDatabase
    {
        public ExcelToDatabase()
        {

        }
        // Method to import data from Excel to the Customers table
        public void ImportExcelToDatabase(string excelFilePath)
        {
            // Open the Excel file using ClosedXML
            using (var workbook = new XLWorkbook(excelFilePath))
            {
                var worksheet = workbook.Worksheet(1); // Assuming data is in the first sheet
                var rows = worksheet.RangeUsed().RowsUsed(); // Get all the rows

                // Prepare SQL connection
                using (SqlConnection conn = Program.GetOpenConnection()) // Replace with your connection method
                {
                   

                    foreach (var row in rows.Skip(1)) // Skip the header row
                    {
                        // Extract data from the Excel row
                        string name = row.Cell(1).GetValue<string>();   // Assuming 'Name' is in column 1
                        string phone = row.Cell(2).GetValue<string>();  // Assuming 'Phone' is in column 2
                        string address = row.Cell(3).GetValue<string>(); // Assuming 'Address' is in column 3
                        try
                        {
                            // Insert data into SQL Customers table
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Customers (Name, Phone, Address) VALUES (@Name, @Phone, @Address)", conn))
                            {
                                cmd.Parameters.AddWithValue("@Name", name);
                                cmd.Parameters.AddWithValue("@Phone", phone);
                                cmd.Parameters.AddWithValue("@Address", address);

                                cmd.ExecuteNonQuery(); // Execute the insert command
                            }
                        }catch (Exception ex)
                        {
                            MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                       
                    }

                    conn.Close();
                }
            }

            Console.WriteLine("Data imported successfully!");
        }
    }
}


