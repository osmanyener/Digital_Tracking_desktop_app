using System;
using System.Data.SqlClient;

namespace mekeceisik_1
{
    internal class PricesOfProducts
    {
        public double ProcessPrice { get; set; }
        public double PriceOfTakenOil { get; set; }
        public double PriceOfSoldOil { get; set; }
        public double PriceOfBeslik { get; set; }
        public double PriceOfOnluk { get; set; }
        public double PriceOfOnSekizlik { get; set; }

        
        public void LoadPricesFromDatabase()
        {
            

            string query = "SELECT processPrice, priceOfTakenOil, priceOfSoldOil, priceOfBeslik, priceOfOnluk, priceOfOnSekizlik FROM PricesTable"; // Adjust to your table

            using (SqlConnection conn = Program.GetOpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        ProcessPrice = Convert.ToDouble(reader["processPrice"]);
                        PriceOfTakenOil = Convert.ToDouble(reader["priceOfTakenOil"]);
                        PriceOfSoldOil = Convert.ToDouble(reader["priceOfSoldOil"]);
                        PriceOfBeslik = Convert.ToDouble(reader["priceOfBeslik"]);
                        PriceOfOnluk = Convert.ToDouble(reader["priceOfOnluk"]);
                        PriceOfOnSekizlik = Convert.ToDouble(reader["priceOfOnSekizlik"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdatePrices(double processPrice, double soldOilPrice, double beslikPrice, double onlukPrice, double onSekizlikPrice)
        {

            // SQL query to update the prices in the pricesTable
            string query = "UPDATE PricesTable SET processPrice = @processPrice, " +
                           "priceOfSoldOil = @priceOfSoldOil, priceOfBeslik = @priceOfBeslik, priceOfOnluk = @priceOfOnluk, " +
                           "priceOfOnSekizlik = @priceOfOnSekizlik";

            // Database connection
            using (SqlConnection conn = Program.GetOpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@ProcessPrice", processPrice);
                        cmd.Parameters.AddWithValue("@PriceOfSoldOil", soldOilPrice);
                        cmd.Parameters.AddWithValue("@PriceOfBeslik", beslikPrice);
                        cmd.Parameters.AddWithValue("@PriceOfOnluk", onlukPrice);
                        cmd.Parameters.AddWithValue("@PriceOfOnSekizlik", onSekizlikPrice);

                        // Execute the update command
                        int rowsAffected = cmd.ExecuteNonQuery();
                        CustomMessageBox.Show("Fiyatlar başarıyla güncellendi.","Bilgi");
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show($"Fiyat güncelleme başarısız!! {ex.Message}", "HATA");
                }
                
            }
        }
    }
}