namespace mekeceisik_1
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btn_dailyReport = new Button();
            btn_printReport = new Button();
            label1 = new Label();
            lbl_nameSurname = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_dailyReport);
            panel1.Controls.Add(btn_printReport);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_nameSurname);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 798);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Zeytin İşleme Raporu", "Yağ satışı Raporu" });
            comboBox1.Location = new Point(396, 288);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 38);
            comboBox1.TabIndex = 59;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(305, 288);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 58;
            label2.Text = "Rapor: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 47);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btn_dailyReport
            // 
            btn_dailyReport.Anchor = AnchorStyles.None;
            btn_dailyReport.BackColor = SystemColors.ActiveCaption;
            btn_dailyReport.Cursor = Cursors.Hand;
            btn_dailyReport.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dailyReport.Location = new Point(752, 711);
            btn_dailyReport.Name = "btn_dailyReport";
            btn_dailyReport.Size = new Size(200, 65);
            btn_dailyReport.TabIndex = 57;
            btn_dailyReport.Text = "Günsonu Al";
            btn_dailyReport.UseVisualStyleBackColor = false;
            btn_dailyReport.Click += btn_dailyReport_Click;
            // 
            // btn_printReport
            // 
            btn_printReport.Anchor = AnchorStyles.None;
            btn_printReport.BackColor = SystemColors.ActiveCaption;
            btn_printReport.Cursor = Cursors.Hand;
            btn_printReport.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_printReport.Location = new Point(461, 522);
            btn_printReport.Name = "btn_printReport";
            btn_printReport.Size = new Size(200, 65);
            btn_printReport.TabIndex = 56;
            btn_printReport.Text = "Raporu Yazdır";
            btn_printReport.UseVisualStyleBackColor = false;
            btn_printReport.Click += btn_printReport_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(213, 345);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 9;
            label1.Text = "Başlangıç Tarihi: ";
            // 
            // lbl_nameSurname
            // 
            lbl_nameSurname.Anchor = AnchorStyles.None;
            lbl_nameSurname.AutoSize = true;
            lbl_nameSurname.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nameSurname.Location = new Point(263, 423);
            lbl_nameSurname.Name = "lbl_nameSurname";
            lbl_nameSurname.Size = new Size(127, 30);
            lbl_nameSurname.TabIndex = 8;
            lbl_nameSurname.Text = "Bitiş Tarihi: ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(396, 423);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(309, 35);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(396, 345);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(309, 35);
            dateTimePicker1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 149);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(996, 822);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mekece Işık";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbl_nameSurname;
        private Button btn_dailyReport;
        private Button btn_printReport;
        private PictureBox pictureBox2;
        private Label label2;
        private ComboBox comboBox1;
    }
}