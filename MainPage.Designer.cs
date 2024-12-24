namespace mekeceisik_1
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panel1 = new Panel();
            btn_settings = new Button();
            pictureBox1 = new PictureBox();
            btn_exit = new Button();
            btn_reports = new Button();
            btn_customerRecords = new Button();
            btn_addCustomer = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btn_settings);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(btn_reports);
            panel1.Controls.Add(btn_customerRecords);
            panel1.Controls.Add(btn_addCustomer);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 801);
            panel1.TabIndex = 0;
            // 
            // btn_settings
            // 
            btn_settings.Anchor = AnchorStyles.None;
            btn_settings.BackColor = SystemColors.ActiveCaption;
            btn_settings.Cursor = Cursors.Hand;
            btn_settings.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_settings.Location = new Point(347, 574);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(289, 75);
            btn_settings.TabIndex = 5;
            btn_settings.Text = "Ayarlar";
            btn_settings.UseVisualStyleBackColor = false;
            btn_settings.Click += btn_settings_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 149);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.None;
            btn_exit.BackColor = SystemColors.ActiveCaption;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.Location = new Point(347, 684);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(289, 75);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Çıkış";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_reports
            // 
            btn_reports.Anchor = AnchorStyles.None;
            btn_reports.BackColor = SystemColors.ActiveCaption;
            btn_reports.Cursor = Cursors.Hand;
            btn_reports.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_reports.Location = new Point(347, 464);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(289, 75);
            btn_reports.TabIndex = 2;
            btn_reports.Text = "Raporlar";
            btn_reports.UseVisualStyleBackColor = false;
            btn_reports.Click += btn_reports_Click;
            // 
            // btn_customerRecords
            // 
            btn_customerRecords.Anchor = AnchorStyles.None;
            btn_customerRecords.BackColor = SystemColors.ActiveCaption;
            btn_customerRecords.Cursor = Cursors.Hand;
            btn_customerRecords.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_customerRecords.Location = new Point(347, 354);
            btn_customerRecords.Name = "btn_customerRecords";
            btn_customerRecords.Size = new Size(289, 75);
            btn_customerRecords.TabIndex = 1;
            btn_customerRecords.Text = "Müşteri Kayıtları";
            btn_customerRecords.UseVisualStyleBackColor = false;
            btn_customerRecords.Click += btn_customerRecords_Click;
            // 
            // btn_addCustomer
            // 
            btn_addCustomer.Anchor = AnchorStyles.None;
            btn_addCustomer.BackColor = SystemColors.ActiveCaption;
            btn_addCustomer.Cursor = Cursors.Hand;
            btn_addCustomer.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addCustomer.Location = new Point(347, 244);
            btn_addCustomer.Name = "btn_addCustomer";
            btn_addCustomer.Size = new Size(289, 75);
            btn_addCustomer.TabIndex = 0;
            btn_addCustomer.Text = "Müşteri Ekle";
            btn_addCustomer.UseVisualStyleBackColor = false;
            btn_addCustomer.Click += btn_addCustomer_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(996, 822);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mekece Işık";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_settings;
        private PictureBox pictureBox1;
        private Button btn_exit;
        private Button btn_reports;
        private Button btn_customerRecords;
        private Button btn_addCustomer;
    }
}
