using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace mekeceisik_1
{
    internal static class Program
    {
        private static string connString = @"Server=.\SQLEXPRESS; Database=Mekece Iþýk; Integrated Security=True;";
        // Define a unique identifier for the mutex
        private static Mutex _mutex = new Mutex(true, "MekeceIþýkAppMutex");

        [STAThread]
        static void Main()
        {
            // Check if a previous instance is already running
            if (!_mutex.WaitOne(TimeSpan.Zero, true))
            {
                // If another instance is running, exit the application
                MessageBox.Show("Program zaten çalýþýyor.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Initialize and start the main application
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPage());

            // Release the mutex when the application closes
            _mutex.ReleaseMutex();
        }

        public static SqlConnection GetOpenConnection()
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        }
    }
}
