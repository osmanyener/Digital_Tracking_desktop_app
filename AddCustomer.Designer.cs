namespace mekeceisik_1
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgw_search = new DataGridView();
            textBox5 = new TextBox();
            label13 = new Label();
            btn_saveCustomer = new Button();
            lbl_phoneNumber = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lbl_nameSurname = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btn_ücret = new RadioButton();
            btn_hak = new RadioButton();
            btn_calculate = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_obtainedOilKg = new TextBox();
            label4 = new Label();
            txt_soldOilKg = new TextBox();
            label3 = new Label();
            txt_oliveKg = new TextBox();
            label2 = new Label();
            txt_nameSurname = new TextBox();
            label1 = new Label();
            tbl_customerData = new DataGridView();
            QueueNumber = new DataGridViewTextBoxColumn();
            NameSurname = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            OliveKg = new DataGridViewTextBoxColumn();
            ClaimedOil = new DataGridViewTextBoxColumn();
            SoldOil = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Claim = new DataGridViewTextBoxColumn();
            Efficiency = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btn_soldOilReport = new Button();
            btn_hesapla = new Button();
            textBox4 = new TextBox();
            label12 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_search).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_customerData).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1815, 824);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 47);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(3, 53);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1812, 765);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ControlLight;
            tabPage1.Controls.Add(dgw_search);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(btn_saveCustomer);
            tabPage1.Controls.Add(lbl_phoneNumber);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(lbl_nameSurname);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1804, 722);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Müşteri Ekle";
            // 
            // dgw_search
            // 
            dgw_search.AllowUserToAddRows = false;
            dgw_search.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dgw_search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgw_search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgw_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgw_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgw_search.DefaultCellStyle = dataGridViewCellStyle3;
            dgw_search.Location = new Point(615, 104);
            dgw_search.Name = "dgw_search";
            dgw_search.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgw_search.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgw_search.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgw_search.RowTemplate.Height = 35;
            dgw_search.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_search.Size = new Size(643, 318);
            dgw_search.TabIndex = 9;
            dgw_search.CellClick += dgw_search_CellClick;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(851, 499);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(261, 39);
            textBox5.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(727, 499);
            label13.Name = "label13";
            label13.Size = new Size(104, 40);
            label13.TabIndex = 7;
            label13.Text = "Adres:";
            // 
            // btn_saveCustomer
            // 
            btn_saveCustomer.BackColor = SystemColors.ActiveCaption;
            btn_saveCustomer.Cursor = Cursors.Hand;
            btn_saveCustomer.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_saveCustomer.Location = new Point(884, 571);
            btn_saveCustomer.Name = "btn_saveCustomer";
            btn_saveCustomer.Size = new Size(228, 73);
            btn_saveCustomer.TabIndex = 8;
            btn_saveCustomer.Text = "Kaydet";
            btn_saveCustomer.UseVisualStyleBackColor = false;
            btn_saveCustomer.Click += btn_saveCustomer_Click;
            // 
            // lbl_phoneNumber
            // 
            lbl_phoneNumber.AutoSize = true;
            lbl_phoneNumber.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_phoneNumber.Location = new Point(705, 428);
            lbl_phoneNumber.Name = "lbl_phoneNumber";
            lbl_phoneNumber.Size = new Size(126, 40);
            lbl_phoneNumber.TabIndex = 5;
            lbl_phoneNumber.Text = "Telefon:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(851, 428);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 39);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(851, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // lbl_nameSurname
            // 
            lbl_nameSurname.AutoSize = true;
            lbl_nameSurname.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nameSurname.Location = new Point(615, 58);
            lbl_nameSurname.Name = "lbl_nameSurname";
            lbl_nameSurname.Size = new Size(216, 40);
            lbl_nameSurname.TabIndex = 0;
            lbl_nameSurname.Text = "İsim - Soyisim:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlLight;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btn_calculate);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txt_obtainedOilKg);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txt_soldOilKg);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txt_oliveKg);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txt_nameSurname);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(tbl_customerData);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1804, 722);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Müşteri Kayıtları";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ücret);
            groupBox1.Controls.Add(btn_hak);
            groupBox1.Location = new Point(1527, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 69);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            // 
            // btn_ücret
            // 
            btn_ücret.AutoSize = true;
            btn_ücret.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ücret.Location = new Point(137, 13);
            btn_ücret.Name = "btn_ücret";
            btn_ücret.Size = new Size(104, 36);
            btn_ücret.TabIndex = 47;
            btn_ücret.TabStop = true;
            btn_ücret.Text = "ÜCRET";
            btn_ücret.UseVisualStyleBackColor = true;
            // 
            // btn_hak
            // 
            btn_hak.AutoSize = true;
            btn_hak.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hak.Location = new Point(10, 13);
            btn_hak.Name = "btn_hak";
            btn_hak.Size = new Size(81, 36);
            btn_hak.TabIndex = 46;
            btn_hak.TabStop = true;
            btn_hak.Text = "HAK";
            btn_hak.UseVisualStyleBackColor = true;
            // 
            // btn_calculate
            // 
            btn_calculate.BackColor = SystemColors.ActiveCaption;
            btn_calculate.Cursor = Cursors.Hand;
            btn_calculate.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_calculate.Location = new Point(1514, 645);
            btn_calculate.Name = "btn_calculate";
            btn_calculate.Size = new Size(287, 73);
            btn_calculate.TabIndex = 54;
            btn_calculate.Text = "Hesapla";
            btn_calculate.UseVisualStyleBackColor = false;
            btn_calculate.Click += btn_calculate_Click;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  ", "21  ", "22  ", "23  ", "24  ", "25  ", "26  ", "27  ", "28  ", "29  ", "30  ", "31  ", "32  ", "33  ", "34  ", "35  ", "36  ", "37  ", "38  ", "39  ", "40  ", "41  ", "42  ", "43  ", "44  ", "45  ", "46  ", "47  ", "48  ", "49  ", "50" });
            comboBox3.Location = new Point(1739, 578);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(62, 38);
            comboBox3.TabIndex = 53;
            comboBox3.Text = "0";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  ", "21  ", "22  ", "23  ", "24  ", "25  ", "26  ", "27  ", "28  ", "29  ", "30  ", "31  ", "32  ", "33  ", "34  ", "35  ", "36  ", "37  ", "38  ", "39  ", "40  ", "41  ", "42  ", "43  ", "44  ", "45  ", "46  ", "47  ", "48  ", "49  ", "50" });
            comboBox2.Location = new Point(1739, 530);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(62, 38);
            comboBox2.TabIndex = 52;
            comboBox2.Text = "0";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  ", "21  ", "22  ", "23  ", "24  ", "25  ", "26  ", "27  ", "28  ", "29  ", "30  ", "31  ", "32  ", "33  ", "34  ", "35  ", "36  ", "37  ", "38  ", "39  ", "40  ", "41  ", "42  ", "43  ", "44  ", "45  ", "46  ", "47  ", "48  ", "49  ", "50" });
            comboBox1.Location = new Point(1739, 481);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(62, 38);
            comboBox1.TabIndex = 51;
            comboBox1.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1514, 578);
            label7.Name = "label7";
            label7.Size = new Size(216, 32);
            label7.TabIndex = 50;
            label7.Text = "18'lik Teneke ---->";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1514, 531);
            label6.Name = "label6";
            label6.Size = new Size(214, 32);
            label6.TabIndex = 49;
            label6.Text = "10'luk Teneke --->";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1514, 482);
            label5.Name = "label5";
            label5.Size = new Size(216, 32);
            label5.TabIndex = 48;
            label5.Text = "5'lik Teneke ----->";
            // 
            // txt_obtainedOilKg
            // 
            txt_obtainedOilKg.Location = new Point(1510, 236);
            txt_obtainedOilKg.Multiline = true;
            txt_obtainedOilKg.Name = "txt_obtainedOilKg";
            txt_obtainedOilKg.Size = new Size(278, 49);
            txt_obtainedOilKg.TabIndex = 42;
            txt_obtainedOilKg.KeyPress += txt_obtainedOilKg_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1510, 201);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 44;
            label4.Text = "Çıkan Yağ";
            // 
            // txt_soldOilKg
            // 
            txt_soldOilKg.Location = new Point(1510, 333);
            txt_soldOilKg.Multiline = true;
            txt_soldOilKg.Name = "txt_soldOilKg";
            txt_soldOilKg.Size = new Size(278, 49);
            txt_soldOilKg.TabIndex = 43;
            txt_soldOilKg.Text = "0";
            txt_soldOilKg.KeyPress += txt_soldOilKg_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1510, 298);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 42;
            label3.Text = "Satılan Yağ";
            // 
            // txt_oliveKg
            // 
            txt_oliveKg.Location = new Point(1510, 140);
            txt_oliveKg.Multiline = true;
            txt_oliveKg.Name = "txt_oliveKg";
            txt_oliveKg.Size = new Size(278, 49);
            txt_oliveKg.TabIndex = 41;
            txt_oliveKg.KeyPress += txt_oliveKg_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1510, 105);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 40;
            label2.Text = "Zeytin Kilosu";
            // 
            // txt_nameSurname
            // 
            txt_nameSurname.Location = new Point(1510, 43);
            txt_nameSurname.Multiline = true;
            txt_nameSurname.Name = "txt_nameSurname";
            txt_nameSurname.Size = new Size(278, 49);
            txt_nameSurname.TabIndex = 39;
            txt_nameSurname.TextChanged += txt_nameSurname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1510, 3);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 38;
            label1.Text = "İsim-Soyisim";
            // 
            // tbl_customerData
            // 
            dataGridViewCellStyle6.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbl_customerData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            tbl_customerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_customerData.Columns.AddRange(new DataGridViewColumn[] { QueueNumber, NameSurname, PhoneNumber, OliveKg, ClaimedOil, SoldOil, Price, Claim, Efficiency });
            tbl_customerData.Location = new Point(0, -3);
            tbl_customerData.MultiSelect = false;
            tbl_customerData.Name = "tbl_customerData";
            tbl_customerData.ReadOnly = true;
            tbl_customerData.RowTemplate.Height = 40;
            tbl_customerData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_customerData.Size = new Size(1504, 725);
            tbl_customerData.TabIndex = 0;
            tbl_customerData.CellClick += tbl_customerData_CellClick;
            // 
            // QueueNumber
            // 
            QueueNumber.DataPropertyName = "QueueNumber";
            dataGridViewCellStyle7.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            QueueNumber.DefaultCellStyle = dataGridViewCellStyle7;
            QueueNumber.HeaderText = "Sıra No";
            QueueNumber.Name = "QueueNumber";
            QueueNumber.ReadOnly = true;
            QueueNumber.Width = 80;
            // 
            // NameSurname
            // 
            NameSurname.DataPropertyName = "Name";
            NameSurname.HeaderText = "İsim-Soyisim";
            NameSurname.Name = "NameSurname";
            NameSurname.ReadOnly = true;
            NameSurname.Width = 200;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "Phone";
            PhoneNumber.HeaderText = "Telefon";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 200;
            // 
            // OliveKg
            // 
            OliveKg.DataPropertyName = "OliveKg";
            OliveKg.HeaderText = "Zeytin Kilosu";
            OliveKg.Name = "OliveKg";
            OliveKg.ReadOnly = true;
            OliveKg.Width = 170;
            // 
            // ClaimedOil
            // 
            ClaimedOil.DataPropertyName = "ClaimedOil";
            ClaimedOil.HeaderText = "Çıkan Yağ";
            ClaimedOil.Name = "ClaimedOil";
            ClaimedOil.ReadOnly = true;
            ClaimedOil.Width = 170;
            // 
            // SoldOil
            // 
            SoldOil.DataPropertyName = "SoldOil";
            SoldOil.HeaderText = "Satılan Yağ(Kg)";
            SoldOil.Name = "SoldOil";
            SoldOil.ReadOnly = true;
            SoldOil.Width = 160;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Ücret";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 160;
            // 
            // Claim
            // 
            Claim.DataPropertyName = "Claim";
            Claim.HeaderText = "Hak";
            Claim.Name = "Claim";
            Claim.ReadOnly = true;
            Claim.Width = 160;
            // 
            // Efficiency
            // 
            Efficiency.DataPropertyName = "Efficiency";
            Efficiency.HeaderText = "Verim";
            Efficiency.Name = "Efficiency";
            Efficiency.ReadOnly = true;
            Efficiency.Width = 160;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlLight;
            tabPage3.Controls.Add(btn_soldOilReport);
            tabPage3.Controls.Add(btn_hesapla);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(comboBox4);
            tabPage3.Controls.Add(comboBox5);
            tabPage3.Controls.Add(comboBox6);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1804, 722);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Yağ Satış";
            // 
            // btn_soldOilReport
            // 
            btn_soldOilReport.BackColor = SystemColors.ActiveCaption;
            btn_soldOilReport.Cursor = Cursors.Hand;
            btn_soldOilReport.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_soldOilReport.Location = new Point(1511, 643);
            btn_soldOilReport.Name = "btn_soldOilReport";
            btn_soldOilReport.Size = new Size(287, 73);
            btn_soldOilReport.TabIndex = 67;
            btn_soldOilReport.Text = "Günsonu Al";
            btn_soldOilReport.UseVisualStyleBackColor = false;
            btn_soldOilReport.Click += btn_soldOilReport_Click;
            // 
            // btn_hesapla
            // 
            btn_hesapla.BackColor = SystemColors.ActiveCaption;
            btn_hesapla.Cursor = Cursors.Hand;
            btn_hesapla.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hesapla.Location = new Point(810, 484);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(287, 73);
            btn_hesapla.TabIndex = 66;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = false;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(810, 241);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 49);
            textBox4.TabIndex = 62;
            textBox4.Text = "0";
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(665, 242);
            label12.Name = "label12";
            label12.Size = new Size(134, 32);
            label12.TabIndex = 62;
            label12.Text = "Satılan Yağ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(810, 155);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 49);
            textBox3.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(649, 156);
            label11.Name = "label11";
            label11.Size = new Size(150, 32);
            label11.TabIndex = 60;
            label11.Text = "İsim-Soyisim";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  ", "21  ", "22  ", "23  ", "24  ", "25  ", "26  ", "27  ", "28  ", "29  ", "30  ", "31  ", "32  ", "33  ", "34  ", "35  ", "36  ", "37  ", "38  ", "39  ", "40  ", "41  ", "42  ", "43  ", "44  ", "45  ", "46  ", "47  ", "48  ", "49  ", "50" });
            comboBox4.Location = new Point(1026, 420);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(62, 38);
            comboBox4.TabIndex = 65;
            comboBox4.Text = "0";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  ", "21  ", "22  ", "23  ", "24  ", "25  ", "26  ", "27  ", "28  ", "29  ", "30  ", "31  ", "32  ", "33  ", "34  ", "35  ", "36  ", "37  ", "38  ", "39  ", "40  ", "41  ", "42  ", "43  ", "44  ", "45  ", "46  ", "47  ", "48  ", "49  ", "50" });
            comboBox5.Location = new Point(1026, 372);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(62, 38);
            comboBox5.TabIndex = 64;
            comboBox5.Text = "0";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  ", "21  ", "22  ", "23  ", "24  ", "25  ", "26  ", "27  ", "28  ", "29  ", "30  ", "31  ", "32  ", "33  ", "34  ", "35  ", "36  ", "37  ", "38  ", "39  ", "40  ", "41  ", "42  ", "43  ", "44  ", "45  ", "46  ", "47  ", "48  ", "49  ", "50" });
            comboBox6.Location = new Point(1026, 323);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(62, 38);
            comboBox6.TabIndex = 63;
            comboBox6.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(801, 420);
            label8.Name = "label8";
            label8.Size = new Size(216, 32);
            label8.TabIndex = 56;
            label8.Text = "18'lik Teneke ---->";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(801, 373);
            label9.Name = "label9";
            label9.Size = new Size(214, 32);
            label9.TabIndex = 55;
            label9.Text = "10'luk Teneke --->";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(801, 324);
            label10.Name = "label10";
            label10.Size = new Size(216, 32);
            label10.TabIndex = 54;
            label10.Text = "5'lik Teneke ----->";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1839, 848);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mekece Işık";
            Load += AddCustomer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_search).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_customerData).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lbl_phoneNumber;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbl_nameSurname;
        private Button btn_saveCustomer;
        private DataGridView tbl_customerData;
        private Button btn_calculate;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private RadioButton btn_ücret;
        private RadioButton btn_hak;
        private TextBox txt_obtainedOilKg;
        private Label label4;
        private TextBox txt_soldOilKg;
        private Label label3;
        private TextBox txt_oliveKg;
        private Label label2;
        private TextBox txt_nameSurname;
        private Label label1;
        private TextBox textBox3;
        private Label label11;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btn_hesapla;
        private TextBox textBox4;
        private Label label12;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label label13;
        private DataGridView dgw_search;
        private GroupBox groupBox1;
        private Button btn_soldOilReport;
        private DataGridViewTextBoxColumn QueueNumber;
        private DataGridViewTextBoxColumn NameSurname;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn OliveKg;
        private DataGridViewTextBoxColumn ClaimedOil;
        private DataGridViewTextBoxColumn SoldOil;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Claim;
        private DataGridViewTextBoxColumn Efficiency;
    }
}