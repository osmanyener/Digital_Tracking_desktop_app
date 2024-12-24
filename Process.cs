using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekeceisik_1
{
    internal class Process
    {
        PricesOfProducts pr = new PricesOfProducts();

        public int ProcessId { get; set; }
        public double OliveKg { get; set; }
        public double ObtainedOil { get; set; }
        public double SoldOil { get; set; }
        public double Price { get; set; }
        public double Claim { get; set; }
        public double Efficiency { get; set; }
        public string? Package { get; set; }
        public string? PurchaseType { get; set; }
        public double PriceOfPackage { get; set; }


        public Process()
        {
            
        }

        public Process(int processId, double oliveKg, double obtainedOil, double soldOil, int numberOfbeslik, int numberOfOnluk, int numberOfOnsekizlik, string? purchaseType)
        {
            pr.LoadPricesFromDatabase();
            ProcessId = processId;
            OliveKg = oliveKg;
            ObtainedOil = obtainedOil;
            SoldOil = soldOil;
            PriceOfPackage = (numberOfbeslik * pr.PriceOfBeslik) + (numberOfOnluk * pr.PriceOfOnluk) + (numberOfOnsekizlik * pr.PriceOfOnSekizlik);
            Price = (oliveKg * pr.ProcessPrice) + (SoldOil * pr.PriceOfSoldOil) + PriceOfPackage;
            Claim = obtainedOil * 0.15;
            Efficiency = oliveKg / obtainedOil;
            Package = $"{numberOfbeslik} beşlik, {numberOfOnluk} onluk, {numberOfOnsekizlik} onsekizlik";
            PurchaseType = purchaseType;
        }


        public void SaveToDB()
        {
            // SQL query to insert the process information into the database
            string query = "INSERT INTO Process (CustomerId, OliveKg, ObtainedOil, SoldOil, Price, Claim, Efficiency, Package, PurchaseType) " +
                           "VALUES (@CustomerId, @OliveKg, @ObtainedOil, @SoldOil, @Price, @Claim, @Efficiency, @Package, @PurchaseType)";

            using (SqlConnection conn = Program.GetOpenConnection()) // Using shared connection method
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@CustomerId", this.ProcessId);
                        cmd.Parameters.AddWithValue("@OliveKg", this.OliveKg);
                        cmd.Parameters.AddWithValue("@ObtainedOil", this.ObtainedOil);
                        cmd.Parameters.AddWithValue("@SoldOil", this.SoldOil);
                        cmd.Parameters.AddWithValue("@Price", this.Price);
                        cmd.Parameters.AddWithValue("@Claim", this.Claim);
                        cmd.Parameters.AddWithValue("@Efficiency", this.Efficiency);
                        cmd.Parameters.AddWithValue("@Package", this.Package);
                        cmd.Parameters.AddWithValue("@PurchaseType", this.PurchaseType);


                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        Console.WriteLine($"Success! {rowsAffected} row(s) inserted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DeleteCustomer(this.ProcessId);
        }
        public void DeleteCustomer(int customerId)
        {
            // SQL query to delete the customer from the Ongoing table
            string deleteQuery = "DELETE FROM Ongoing WHERE OnGoingId = @CustomerId";

            using (SqlConnection conn = Program.GetOpenConnection()) // Assuming you have a shared connection method in Program.cs
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        // Add the customerId as a parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);

                        // Execute the delete command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Success! {rowsAffected} row(s) deleted from Ongoing table.");

                        }
                        else
                        {
                            Console.WriteLine("No customer found with the given CustomerId.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




    }
}
