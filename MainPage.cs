namespace mekeceisik_1
{
    public partial class MainPage : Form
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new AddCustomer(this))
            {
                this.Hide();
                addCustomerForm.ShowDialog();
                this.Show(); // Shows MainPage again after AddCustomer is closed
            }
        }

        private void btn_customerRecords_Click(object sender, EventArgs e)
        {
            using (var customerRecordsForm = new CustomerRecords(this))
            {
                this.Hide();
                customerRecordsForm.ShowDialog();
                this.Show(); // Shows MainPage again after CustomerRecords is closed
            }
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            using (var reportsForm = new Reports(this))
            {
                this.Hide();
                reportsForm.ShowDialog();
                this.Show(); // Shows MainPage again after Reports is closed
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Exits the application
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new Settings(this))
            {
                this.Hide();
                settingsForm.ShowDialog();
                this.Show(); // Shows MainPage again after Settings is closed
            }
        }
    }
}
