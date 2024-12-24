using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekeceisik_1
{
    internal class CalculateTotal
    {
        //double totalOliveWeight = 0;
        //double totalObtainedOil = 0;
        //double totalPrice = 0;
        //double totalClaim = 0;
        //double totalSoldOil = 0;
        //double efficiencySum = 0;
        //int rowCount = 0;
        //int beslik = 0;
        //int onluk = 0;
        //int onsekizlik = 0;


        public void CalcDailyTotal()
        {
            double totalOliveWeight = 0;
            double totalObtainedOil = 0;
            double totalPrice = 0;
            double totalClaim = 0;
            double totalSoldOil = 0;
            double efficiencySum = 0;
            int rowCount = 0;

            string query = "SELECT OliveKg, ObtainedOil, SoldOil, Price, Claim, Efficiency, PurchaseType FROM Process WHERE CAST([Date] AS DATE) = CAST(GETDATE() AS DATE)";

            using (SqlConnection conn = Program.GetOpenConnection()) // Assuming Program.GetOpenConnection is your method
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string? type = Convert.ToString(reader["PurchaseType"]);
                            if (type == "ÜCRET")
                            {
                                totalPrice += Convert.ToDouble(reader["Price"]);
                            }
                            else if (type == "HAK")
                            {
                                totalClaim += Convert.ToDouble(reader["Claim"]);
                            }
                            // Accumulate values from the database
                            totalOliveWeight += Convert.ToDouble(reader["OliveKg"]);
                            totalObtainedOil += Convert.ToDouble(reader["ObtainedOil"]);
                            totalSoldOil += Convert.ToDouble(reader["SoldOil"]);
                            efficiencySum += Convert.ToDouble(reader["Efficiency"]);
                            rowCount++;
                        }
                    }
                }
            }

            // Calculate average efficiency if there are rows processed today
            double averageEfficiency = rowCount > 0 ? efficiencySum / rowCount : 0;

            // Get current date
            string date = DateTime.Now.ToString("dd/MM/yyyy");

            // Create and print the report
            Reports printer = new Reports(date, totalOliveWeight, totalObtainedOil, totalPrice, totalClaim, totalSoldOil, averageEfficiency);
            printer.PrintProcessReport();
        }

        public void CalculateTotalsBetweenDates(DateTime startDate, DateTime endDate)
        {
            // Initialize totals
            double totalOliveWeight = 0;
            double totalObtainedOil = 0;
            double totalPrice = 0;
            double totalClaim = 0;
            double totalSoldOil = 0;
            double efficiencySum = 0;
            int rowCount = 0;

            // SQL query to get records between two dates
            string query = "SELECT OliveKg, ObtainedOil, SoldOil, Price, Claim, Efficiency, PurchaseType " +
                           "FROM Process " +
                           "WHERE CAST([Date] AS DATE) BETWEEN @startDate AND @endDate";

            using (SqlConnection conn = Program.GetOpenConnection()) // Assuming Program.GetOpenConnection is your method
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for start and end dates
                    cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                    cmd.Parameters.AddWithValue("@endDate", endDate.Date);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string? type = Convert.ToString(reader["PurchaseType"]);
                            if (type == "ÜCRET")
                            {
                                totalPrice += Convert.ToDouble(reader["Price"]);
                            }
                            else if (type == "HAK")
                            {
                                totalClaim += Convert.ToDouble(reader["Claim"]);
                            }

                            // Accumulate values from the database
                            totalOliveWeight += Convert.ToDouble(reader["OliveKg"]);
                            totalObtainedOil += Convert.ToDouble(reader["ObtainedOil"]);
                            totalSoldOil += Convert.ToDouble(reader["SoldOil"]);
                            efficiencySum += Convert.ToDouble(reader["Efficiency"]);
                            rowCount++;
                        }
                    }
                }
            }

            // Calculate average efficiency if there are rows between the two dates
            double averageEfficiency = rowCount > 0 ? efficiencySum / rowCount : 0;

            // Get current date range as a string for the report
            string dateRange = $"{startDate:dd/MM/yyyy} - {endDate:dd/MM/yyyy}";

            // Create and print the report
            Reports printer = new Reports(dateRange, totalOliveWeight, totalObtainedOil, totalPrice, totalClaim, totalSoldOil, averageEfficiency);
            printer.PrintProcessReport();
        }

        public void CalcTotalSoldOil()
        {
            double totalPrice = 0;
            double totalSoldOil = 0;
            int beslik = 0;
            int onluk = 0;
            int onsekizlik = 0;

            string query = "SELECT OilKg, five, ten, eightteen, TotalPrice FROM SellOil WHERE CAST([Date] AS DATE) = CAST(GETDATE() AS DATE)";

            using (SqlConnection conn = Program.GetOpenConnection()) // Assuming Program.GetOpenConnection is your method
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            totalPrice += Convert.ToDouble(reader["TotalPrice"]);
                            totalSoldOil += Convert.ToDouble(reader["OilKg"]);
                            beslik += Convert.ToInt16(reader["five"]);
                            onluk += Convert.ToInt16(reader["ten"]);
                            onsekizlik += Convert.ToInt16(reader["eightteen"]);
                        }
                    }
                }
            }
            string date = DateTime.Now.ToString("dd/MM/yyyy");

            Reports printer = new Reports(date, totalSoldOil, beslik, onluk, onsekizlik, totalPrice);
            printer.PrintSoldOilReport();
        }

        public void CalcTotalSoldOilBetweenDates(DateTime startDate, DateTime endDate)
        {
            double totalPrice = 0;
            double totalSoldOil = 0;
            int beslik = 0;
            int onluk = 0;
            int onsekizlik = 0;

            string query = "SELECT OilKg, five, ten, eightteen, TotalPrice FROM SellOil WHERE CAST([Date] AS DATE) BETWEEN @startDate AND @endDate";

            using (SqlConnection conn = Program.GetOpenConnection()) // Assuming Program.GetOpenConnection is your method
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for start and end dates
                    cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                    cmd.Parameters.AddWithValue("@endDate", endDate.Date);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            totalPrice += Convert.ToDouble(reader["TotalPrice"]);
                            totalSoldOil += Convert.ToDouble(reader["OilKg"]);
                            beslik += Convert.ToInt16(reader["five"]);
                            onluk += Convert.ToInt16(reader["ten"]);
                            onsekizlik += Convert.ToInt16(reader["eightteen"]);
                        }
                    }
                }
            }
            string dateRange = $"{startDate:dd/MM/yyyy} - {endDate:dd/MM/yyyy}";

            Reports printer = new Reports(dateRange, totalSoldOil, beslik, onluk, onsekizlik, totalPrice);
            printer.PrintSoldOilReport();
        }

    }
}
