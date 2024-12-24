namespace mekeceisik_1
{
    partial class CustomerRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRecords));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txt_search = new TextBox();
            lbl_search = new Label();
            pictureBox1 = new PictureBox();
            btn_exportExcel = new Button();
            tbl_customerRecords = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbl_customerRecords).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(lbl_search);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_exportExcel);
            panel1.Controls.Add(tbl_customerRecords);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1815, 824);
            panel1.TabIndex = 2;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txt_search.Location = new Point(1463, 7);
            txt_search.Multiline = true;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(271, 40);
            txt_search.TabIndex = 58;
            txt_search.TextChanged += textBox1_TextChanged;
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_search.Location = new Point(1392, 10);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(65, 32);
            lbl_search.TabIndex = 57;
            lbl_search.Text = "Ara: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 47);
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_exportExcel
            // 
            btn_exportExcel.BackColor = SystemColors.ActiveCaption;
            btn_exportExcel.Cursor = Cursors.Hand;
            btn_exportExcel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exportExcel.Location = new Point(1513, 748);
            btn_exportExcel.Name = "btn_exportExcel";
            btn_exportExcel.Size = new Size(287, 73);
            btn_exportExcel.TabIndex = 55;
            btn_exportExcel.Text = "Excel'e Aktar";
            btn_exportExcel.UseVisualStyleBackColor = false;
            btn_exportExcel.Click += btn_exportExcel_Click;
            // 
            // tbl_customerRecords
            // 
            tbl_customerRecords.AllowUserToAddRows = false;
            tbl_customerRecords.AllowUserToDeleteRows = false;
            tbl_customerRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbl_customerRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbl_customerRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_customerRecords.Location = new Point(0, 53);
            tbl_customerRecords.Name = "tbl_customerRecords";
            tbl_customerRecords.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tbl_customerRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbl_customerRecords.RowsDefaultCellStyle = dataGridViewCellStyle3;
            tbl_customerRecords.RowTemplate.Height = 35;
            tbl_customerRecords.Size = new Size(1812, 694);
            tbl_customerRecords.TabIndex = 1;
            // 
            // CustomerRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1839, 848);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mekece Işık";
            Load += CustomerRecords_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbl_customerRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btn_exportExcel;
        private PictureBox pictureBox1;
        private DataGridView tbl_customerRecords;
        private TextBox txt_search;
        private Label lbl_search;
    }
}