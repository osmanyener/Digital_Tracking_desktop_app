using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;


namespace mekeceisik_1
{
    public partial class AddCustomer : Form
    {
        private MainPage mainPage;
        Customer c = new Customer();
        

        public AddCustomer(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }


        private void btn_saveCustomer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Customer customer = new Customer(textBox1.Text, textBox2.Text, textBox5.Text);
                int queueNumber = customer.GetAndIncrementQueueNumber();
                CustomMessageBox.Show("Sıra Numarası: " + queueNumber, "Bilgi");
                customer.SaveToDB();
                tbl_customerData.DataSource = customer.LoadDataFromDatabase();
                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
            }
            else
            {
                MessageBox.Show("İsim - Soyisim ve Telefon alanı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            mainPage.Show();
            this.Close();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" || textBox4.Text != "")
            {
                OilCustomers oilCustomer = new OilCustomers(textBox3.Text, Convert.ToDouble(textBox4.Text), Convert.ToInt32(comboBox6.Text), Convert.ToInt32(comboBox5.Text), Convert.ToInt32(comboBox4.Text));
                CustomMessageBox.Show("Toplam Ücret: " + Math.Round(oilCustomer.TotalPrice, 2), "Hesap");
                oilCustomer.SaveToDB();
                Reports printer = new Reports(textBox3.Text, oilCustomer.OilKg, oilCustomer.NumberOfBeslik, oilCustomer.NumberOfOnluk, oilCustomer.NumberOfOnSekizlik, oilCustomer.TotalPrice);
                printer.PrintSoldOilReceipt();
                textBox3.Clear();
                textBox4.Clear();
                comboBox6.Text = Convert.ToString(0);
                comboBox5.Text = Convert.ToString(0);
                comboBox4.Text = Convert.ToString(0);

            }
            else
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox4.Text = "0";
        }



        private void btn_calculate_Click(object sender, EventArgs e)
        {
            Process process;
            int id = c.FindId(tbl_customerData.CurrentRow.Cells["NameSurname"].Value?.ToString(), tbl_customerData.CurrentRow.Cells["PhoneNumber"].Value?.ToString());
            if (txt_oliveKg.Text == "" || txt_obtainedOilKg.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!btn_hak.Checked && !btn_ücret.Checked)
                {
                    MessageBox.Show("HAK veya ÜCRET'i seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (btn_hak.Checked)
                    {
                        process = new Process(id, Convert.ToDouble(txt_oliveKg.Text), Convert.ToDouble(txt_obtainedOilKg.Text),
                   Convert.ToDouble(txt_soldOilKg.Text), Convert.ToInt16(comboBox1.Text),
                   Convert.ToInt16(comboBox2.Text), Convert.ToInt16(comboBox3.Text), btn_hak.Text);
                        CustomMessageBox.Show("Toplam Hak: " + Math.Round(process.Claim, 2) + "\n Teneke Ücreti: " + process.PriceOfPackage, "Bilgi");

                        tbl_customerData.CurrentRow.Cells["OliveKg"].Value = process.OliveKg;
                        tbl_customerData.CurrentRow.Cells["ClaimedOil"].Value = process.ObtainedOil;
                        tbl_customerData.CurrentRow.Cells["SoldOil"].Value = process.SoldOil;
                        tbl_customerData.CurrentRow.Cells["Price"].Value = process.Price;
                        tbl_customerData.CurrentRow.Cells["Claim"].Value = process.Claim;
                        tbl_customerData.CurrentRow.Cells["Efficiency"].Value = process.Efficiency;
                        process.SaveToDB();
                        Reports printer = new Reports(txt_nameSurname.Text, Convert.ToDouble(txt_oliveKg.Text), Convert.ToDouble(txt_obtainedOilKg.Text), process.PriceOfPackage, process.Claim, Convert.ToDouble(txt_soldOilKg.Text), process.Efficiency,
                            Convert.ToInt16(comboBox1.Text), Convert.ToInt16(comboBox2.Text), Convert.ToInt16(comboBox3.Text));
                        printer.PrintProcessReceipt();



                    }
                    else if (btn_ücret.Checked)
                    {
                        process = new Process(id, Convert.ToDouble(txt_oliveKg.Text), Convert.ToDouble(txt_obtainedOilKg.Text),
                    Convert.ToDouble(txt_soldOilKg.Text), Convert.ToInt16(comboBox1.Text),
                    Convert.ToInt16(comboBox2.Text), Convert.ToInt16(comboBox3.Text), btn_ücret.Text);
                        CustomMessageBox.Show("Toplam Ücret: " + Math.Round(process.Price, 1), "Bilgi");

                        tbl_customerData.CurrentRow.Cells["OliveKg"].Value = process.OliveKg;
                        tbl_customerData.CurrentRow.Cells["ClaimedOil"].Value = process.ObtainedOil;
                        tbl_customerData.CurrentRow.Cells["SoldOil"].Value = process.SoldOil;
                        tbl_customerData.CurrentRow.Cells["Price"].Value = process.Price;
                        tbl_customerData.CurrentRow.Cells["Claim"].Value = process.Claim;
                        tbl_customerData.CurrentRow.Cells["Efficiency"].Value = process.Efficiency;
                        process.SaveToDB();
                        Reports printer = new Reports(txt_nameSurname.Text, Convert.ToDouble(txt_oliveKg.Text), Convert.ToDouble(txt_obtainedOilKg.Text), process.Price, 0, Convert.ToDouble(txt_soldOilKg.Text), process.Efficiency,
                           Convert.ToInt16(comboBox1.Text), Convert.ToInt16(comboBox2.Text), Convert.ToInt16(comboBox3.Text));

                        printer.PrintProcessReceipt();
                    }


                    txt_oliveKg.Clear();
                    txt_obtainedOilKg.Clear();
                    txt_soldOilKg.Text = "0";
                    txt_nameSurname.Clear();
                    comboBox1.Text = "0";
                    comboBox2.Text = "0";
                    comboBox3.Text = "0";
                    btn_hak.Checked = false;
                    btn_ücret.Checked = false;
                }

            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void tbl_customerData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = tbl_customerData.Rows[e.RowIndex];


                txt_nameSurname.Text = selectedRow.Cells["NameSurname"].Value.ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dgw_search.DataSource = c.SearchCustomer(textBox1.Text);
        }
        private void txt_nameSurname_TextChanged(object sender, EventArgs e)
        {
            tbl_customerData.DataSource = c.SearchByName(txt_nameSurname.Text);
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            
            tbl_customerData.DataSource = c.LoadDataFromDatabase();


        }

        private void dgw_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Safely get and trim the cell values before assigning them
                textBox1.Text = dgw_search.CurrentRow.Cells[0].Value?.ToString().Trim() ?? "N/A";
                textBox2.Text = dgw_search.CurrentRow.Cells[1].Value?.ToString().Trim() ?? "N/A";
                textBox5.Text = dgw_search.CurrentRow.Cells[2].Value?.ToString().Trim() ?? "N/A";
            }
        }


        private void btn_soldOilReport_Click(object sender, EventArgs e)
        {
            CalculateTotal clc = new CalculateTotal();
            clc.CalcTotalSoldOil();
        }

        private void txt_oliveKg_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Allow control keys (like backspace)
            if (char.IsControl(e.KeyChar))
            {
                return; // Allow control keys
            }

            // Check if the key is a digit
            if (char.IsDigit(e.KeyChar))
            {
                return; // Allow digits
            }

            // Check if the key is a period or comma
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // If it's a period, replace it with a comma
                if (e.KeyChar == '.' && !txt_oliveKg.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the period key press
                                      // Replace period with comma
                    int selectionStart = txt_oliveKg.SelectionStart;
                    txt_oliveKg.Text = txt_oliveKg.Text.Insert(selectionStart, ",");
                    txt_oliveKg.SelectionStart = selectionStart + 1; // Move the caret position after the inserted comma
                }

                // Allow the comma only if there is no other comma in the text
                if (txt_oliveKg.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the key press if a comma already exists
                }

                return; // Exit the method after handling period and comma
            }

            // If the key is neither a digit, period, nor comma, ignore the key press
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Allow control keys (like backspace)
            if (char.IsControl(e.KeyChar))
            {
                return; // Allow control keys
            }

            // Check if the key is a digit
            if (char.IsDigit(e.KeyChar))
            {
                return; // Allow digits
            }

            // Check if the key is a period or comma
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // If it's a period, replace it with a comma
                if (e.KeyChar == '.' && !textBox4.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the period key press
                                      // Replace period with comma
                    int selectionStart = textBox4.SelectionStart;
                    textBox4.Text = textBox4.Text.Insert(selectionStart, ",");
                    textBox4.SelectionStart = selectionStart + 1; // Move the caret position after the inserted comma
                }

                // Allow the comma only if there is no other comma in the text
                if (textBox4.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the key press if a comma already exists
                }

                return; // Exit the method after handling period and comma
            }

            // If the key is neither a digit, period, nor comma, ignore the key press
            e.Handled = true;
        }

        private void txt_obtainedOilKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (like backspace)
            if (char.IsControl(e.KeyChar))
            {
                return; // Allow control keys
            }

            // Check if the key is a digit
            if (char.IsDigit(e.KeyChar))
            {
                return; // Allow digits
            }

            // Check if the key is a period or comma
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // If it's a period, replace it with a comma
                if (e.KeyChar == '.' && !txt_obtainedOilKg.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the period key press
                                      // Replace period with comma
                    int selectionStart = txt_obtainedOilKg.SelectionStart;
                    txt_obtainedOilKg.Text = txt_obtainedOilKg.Text.Insert(selectionStart, ",");
                    txt_obtainedOilKg.SelectionStart = selectionStart + 1; // Move the caret position after the inserted comma
                }

                // Allow the comma only if there is no other comma in the text
                if (txt_obtainedOilKg.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the key press if a comma already exists
                }

                return; // Exit the method after handling period and comma
            }

            // If the key is neither a digit, period, nor comma, ignore the key press
            e.Handled = true;
        }

        private void txt_soldOilKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (like backspace)
            if (char.IsControl(e.KeyChar))
            {
                return; // Allow control keys
            }

            // Check if the key is a digit
            if (char.IsDigit(e.KeyChar))
            {
                return; // Allow digits
            }

            // Check if the key is a period or comma
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // If it's a period, replace it with a comma
                if (e.KeyChar == '.' && !txt_soldOilKg.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the period key press
                                      // Replace period with comma
                    int selectionStart = txt_soldOilKg.SelectionStart;
                    txt_soldOilKg.Text = txt_soldOilKg.Text.Insert(selectionStart, ",");
                    txt_soldOilKg.SelectionStart = selectionStart + 1; // Move the caret position after the inserted comma
                }

                // Allow the comma only if there is no other comma in the text
                if (txt_soldOilKg.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the key press if a comma already exists
                }

                return; // Exit the method after handling period and comma
            }

            // If the key is neither a digit, period, nor comma, ignore the key press
            e.Handled = true;
        }

        

        
    }
}
