using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekeceisik_1
{
    internal class OilCustomers
    {
        PricesOfProducts A = new PricesOfProducts();
        
       
        public string? Name { get; set; }
        public double OilKg { get; set; }
        public int NumberOfBeslik { get; set; }
        public int NumberOfOnluk { get; set; }
        public int NumberOfOnSekizlik { get; set; }
        public double TotalPrice { get; set; }



        public OilCustomers()
        {

        }
        public OilCustomers(string nameSurname, double oilkg, int numberofbeslik, int numberofonluk, int numberofonsekizlik )
        {
            A.LoadPricesFromDatabase();
            Name = nameSurname;
            OilKg = oilkg;
            NumberOfBeslik = numberofbeslik;
            NumberOfOnluk = numberofonluk;
            NumberOfOnSekizlik = numberofonsekizlik;
            TotalPrice = (OilKg * A.PriceOfSoldOil) + (NumberOfBeslik * (A.PriceOfSoldOil * 5)) + (NumberOfOnluk * (A.PriceOfSoldOil * 10)) + (NumberOfOnSekizlik * (A.PriceOfSoldOil * 18));
        }


        public void SaveToDB()
        {
            string query = "INSERT INTO SellOil (Name, OilKg, five, ten, eightteen, TotalPrice) " +
                           "VALUES (@Name, @OilKg, @five, @ten, @eightteen, @TotalPrice)";

            using (SqlConnection conn = Program.GetOpenConnection()) 
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@OilKg", this.OilKg);
                        cmd.Parameters.AddWithValue("@five", this.NumberOfBeslik);
                        cmd.Parameters.AddWithValue("@ten", this.NumberOfOnluk);
                        cmd.Parameters.AddWithValue("@eightteen", this.NumberOfOnSekizlik);
                        cmd.Parameters.AddWithValue("@TotalPrice", this.TotalPrice);
                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        Console.WriteLine($"Success! {rowsAffected} row(s) inserted.");
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
