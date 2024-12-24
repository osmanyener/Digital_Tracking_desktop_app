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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            // Set the message and title
            this.Text = title;
            lblMessage.Text = message;

            // Customize the font
            lblMessage.Font = new Font("Arial", 22, FontStyle.Bold);
        }

        public static DialogResult Show(string message, string title)
        {
            using (CustomMessageBox msgBox = new CustomMessageBox(message, title))
            {
                return msgBox.ShowDialog();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
