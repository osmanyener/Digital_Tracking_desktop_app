using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mekeceisik_1
{
    internal class Customer
    {
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }


        public int QueueNumber { get; private set; }

        public Customer(string nameSurname, string phone, string address)
        {
            NameSurname = nameSurname;
            Phone = phone;
            Address = address;

        }

        public Customer()
        {
           
        }


        public int FindId(string? name, string? phone)
        {
            string checkCustomerQuery = "SELECT CustomerId FROM Customers WHERE Name = @Name AND Phone = @Phone";
            int result = 0;
            using (SqlConnection conn = Program.GetOpenConnection())
            {
                try
                {
                    using (SqlCommand checkCmd = new SqlCommand(checkCustomerQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Name", name);
                        checkCmd.Parameters.AddWithValue("@Phone", phone);
                        result = Convert.ToInt16(checkCmd.ExecuteScalar()); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}","Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
            return result;
        }
        public object? FindIdBool(string name, string phone)
        {
            string checkCustomerQuery = "SELECT CustomerId FROM Customers WHERE Name = @Name AND Phone = @Phone";
            object? result = null;
            using (SqlConnection conn = Program.GetOpenConnection())
            {
                try
                {
                    using (SqlCommand checkCmd = new SqlCommand(checkCustomerQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Name", name);
                        checkCmd.Parameters.AddWithValue("@Phone", phone);
                        result = checkCmd.ExecuteScalar(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }


       

        public void SaveToDB()
        {
            string insertCustomerQuery = "INSERT INTO Customers (Name, Phone, Address) VALUES (@Name, @Phone, @Address); SELECT SCOPE_IDENTITY();";

            string insertOngoingQuery = "INSERT INTO Ongoing (OngoingId, QueueNumber, Name, Phone, Address) VALUES (@CustomerId, @QueueNumber, @Name, @Phone, @Address)";

            using (SqlConnection conn = Program.GetOpenConnection())
            {
                try
                {
                    
                        object result = FindIdBool(this.NameSurname, this.Phone); 

                        int customerId;
                        if (result == null) // Customer doesn't exist
                        {
                            
                            using (SqlCommand insertCustomerCmd = new SqlCommand(insertCustomerQuery, conn))
                            {
                                insertCustomerCmd.Parameters.AddWithValue("@Name", this.NameSurname);
                                insertCustomerCmd.Parameters.AddWithValue("@Phone", this.Phone);
                                insertCustomerCmd.Parameters.AddWithValue("@Address", this.Address);

                                
                                customerId = Convert.ToInt32(insertCustomerCmd.ExecuteScalar());
                                Console.WriteLine("Customer added to Customers table.");

                                
                                using (SqlCommand insertOngoingCmd = new SqlCommand(insertOngoingQuery, conn))
                                {
                                    insertOngoingCmd.Parameters.AddWithValue("@CustomerId", customerId);
                                    insertOngoingCmd.Parameters.AddWithValue("@QueueNumber", this.QueueNumber);
                                    insertOngoingCmd.Parameters.AddWithValue("@Name", this.NameSurname);
                                    insertOngoingCmd.Parameters.AddWithValue("@Phone", this.Phone);
                                    insertOngoingCmd.Parameters.AddWithValue("@Address", this.Address);

                                    
                                    int rowsAffected = insertOngoingCmd.ExecuteNonQuery();
                                    Console.WriteLine($"Success! {rowsAffected} row(s) inserted into Ongoing table.");
                                }
                            }
                        }
                        else
                        {
                            // Customer exists, use the existing CustomerId and add to Ongoing table
                            customerId = Convert.ToInt32(result);

                            using (SqlCommand insertOngoingCmd = new SqlCommand(insertOngoingQuery, conn))
                            {
                                insertOngoingCmd.Parameters.AddWithValue("@CustomerId", customerId); 
                                insertOngoingCmd.Parameters.AddWithValue("@QueueNumber", this.QueueNumber);
                                insertOngoingCmd.Parameters.AddWithValue("@Name", this.NameSurname);
                                insertOngoingCmd.Parameters.AddWithValue("@Phone", this.Phone);
                                insertOngoingCmd.Parameters.AddWithValue("@Address", this.Address);
                                //checkAddress(customerId,this.Address);

                               
                                int rowsAffected = insertOngoingCmd.ExecuteNonQuery();
                                Console.WriteLine($"Success! {rowsAffected} row(s) inserted into Ongoing table.");
                            }
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //projeden kaldırabilir. ekstra. eski bir hata düzeltmek için.
        public void checkAddress(int cId, string? addr)
        {
            try
            {
                using (SqlConnection conn = Program.GetOpenConnection())
                {
                    
                    string checkAddressQuery = "SELECT Address FROM Customers WHERE CustomerId = @CustomerId";
                    using (SqlCommand checkAddressCmd = new SqlCommand(checkAddressQuery, conn))
                    {
                        checkAddressCmd.Parameters.AddWithValue("@CustomerId", cId);
                        object addressResult = checkAddressCmd.ExecuteScalar();

                        if (addressResult == DBNull.Value || string.IsNullOrEmpty(addressResult.ToString()))
                        {
                            
                            string updateAddressQuery = "UPDATE Customers SET Address = @NewAddress WHERE CustomerId = @CustomerId";
                            using (SqlCommand updateAddressCmd = new SqlCommand(updateAddressQuery, conn))
                            {
                                updateAddressCmd.Parameters.AddWithValue("@NewAddress", addr);
                                updateAddressCmd.Parameters.AddWithValue("@CustomerId", cId);

                                int rowsUpdated = updateAddressCmd.ExecuteNonQuery();
                                Console.WriteLine($"Address updated for customer ID {cId}. Rows affected: {rowsUpdated}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
             
        }

        public DataTable LoadDataFromDatabase()
        {
            string query = "SELECT QueueNumber, Name, Phone FROM OnGoing ORDER BY QueueNumber";

            using (SqlConnection conn = Program.GetOpenConnection())
            {
                DataTable dataTable = new DataTable();
                try
                {

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    dataAdapter.Fill(dataTable);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return dataTable;
            }
        }

        public DataTable LoadDataFromDatabase_2()
        {
            string query = "SELECT Name, Phone, Address FROM Customers ORDER BY CustomerId";

            using (SqlConnection conn = Program.GetOpenConnection())
            {
                DataTable dataTable = new DataTable();
                try
                {

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    dataAdapter.Fill(dataTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return dataTable;
            }
        }
        public DataView SearchCustomer(string key)
        {
            var customerDataTable = LoadDataFromDatabase_2();
            
            
            if (customerDataTable == null || customerDataTable.Rows.Count == 0)
                return new DataView();

            DataView dv = customerDataTable.DefaultView;

            dv.RowFilter = $"(CONVERT(Name, 'System.String') LIKE '%{key.ToLower()}%')";

            return dv;
        }
        public DataView SearchByName(string name)
        {

            var customerDataTable = LoadDataFromDatabase() ;

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


        public int GetAndIncrementQueueNumber()
        {
            int queueNumber = 0;

            using (SqlConnection conn = Program.GetOpenConnection())
            {
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                  
                    string selectQuery = "SELECT CurrentQueueNumber, LastResetDate FROM QueueInfo WHERE Id = 1";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, conn, transaction);

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int currentQueueNumber = reader.GetInt32(0);
                            DateTime lastResetDate = reader.GetDateTime(1);

                            
                            if (lastResetDate.Date < DateTime.Now.Date)
                            {
                                
                                currentQueueNumber = 1;
                                lastResetDate = DateTime.Now.Date;  
                            }
                            else
                            {
                                
                                currentQueueNumber++;
                            }

                            queueNumber = currentQueueNumber;
                            QueueNumber=queueNumber;
                            reader.Close();

                            
                            string updateQuery = "UPDATE QueueInfo SET CurrentQueueNumber = @QueueNumber, LastResetDate = @LastResetDate WHERE Id = 1";
                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                            updateCmd.Parameters.AddWithValue("@QueueNumber", currentQueueNumber);
                            updateCmd.Parameters.AddWithValue("@LastResetDate", lastResetDate);
                            updateCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Hata: {ex.Message}", "Hata Detayları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return queueNumber;
        }
    }
}
