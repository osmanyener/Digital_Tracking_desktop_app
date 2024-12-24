using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mekeceisik_1
{
    public partial class Settings : Form
    {
        private MainPage mainPage;
        public Settings(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            PricesOfProducts pr = new PricesOfProducts();
            pr.LoadPricesFromDatabase();
            textBox1.Text = Convert.ToString(pr.ProcessPrice);
            textBox3.Text = Convert.ToString(pr.PriceOfSoldOil);
            textBox4.Text = Convert.ToString(pr.PriceOfBeslik);
            textBox5.Text = Convert.ToString(pr.PriceOfOnluk);
            textBox6.Text = Convert.ToString(pr.PriceOfOnSekizlik);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            PricesOfProducts pr = new PricesOfProducts();
            pr.UpdatePrices(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text),
                Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainPage.Show();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
                if (e.KeyChar == '.' && !textBox1.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the period key press
                                      // Replace period with comma
                    int selectionStart = textBox1.SelectionStart;
                    textBox1.Text = textBox1.Text.Insert(selectionStart, ",");
                    textBox1.SelectionStart = selectionStart + 1; // Move the caret position after the inserted comma
                }

                // Allow the comma only if there is no other comma in the text
                if (textBox1.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the key press if a comma already exists
                }

                return; // Exit the method after handling period and comma
            }

            // If the key is neither a digit, period, nor comma, ignore the key press
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
                if (e.KeyChar == '.' && !textBox3.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the period key press
                                      // Replace period with comma
                    int selectionStart = textBox3.SelectionStart;
                    textBox3.Text = textBox3.Text.Insert(selectionStart, ",");
                    textBox3.SelectionStart = selectionStart + 1; // Move the caret position after the inserted comma
                }

                // Allow the comma only if there is no other comma in the text
                if (textBox3.Text.Contains(","))
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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
                if (e.KeyChar == '.' && !textBox5.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the period key press
                                      // Replace period with comma
                    int selectionStart = textBox5.SelectionStart;
                    textBox5.Text = textBox5.Text.Insert(selectionStart, ",");
                    textBox5.SelectionStart = selectionStart + 1; // Move the caret position after the inserted comma
                }

                // Allow the comma only if there is no other comma in the text
                if (textBox5.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the key press if a comma already exists
                }

                return; // Exit the method after handling period and comma
            }

            // If the key is neither a digit, period, nor comma, ignore the key press
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
                if (e.KeyChar == '.' && !textBox6.Text.Contains(","))
                {
                    e.Handled = true; // Ignore the period key press
                                      // Replace period with comma
                    int selectionStart = textBox6.SelectionStart;
                    textBox6.Text = textBox6.Text.Insert(selectionStart, ",");
                    textBox6.SelectionStart = selectionStart + 1; // Move the caret position after the inserted comma
                }

                // Allow the comma only if there is no other comma in the text
                if (textBox6.Text.Contains(","))
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
