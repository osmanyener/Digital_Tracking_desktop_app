using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mekeceisik_1
{
    public partial class Reports : Form
    {
        private MainPage mainPage;
        private string? date;
        private string? name;
        private double totalOliveWeight;
        private double totalObtainedOil;
        private double totalPrice;
        private double totalClaim;
        private double totalSoldOil;
        private double efficiency;
        private int numberOfBeslik;
        private int numberOfOnluk;
        private int numberOfOnSekizlik;
        CalculateTotal clc = new CalculateTotal();
        PricesOfProducts pr = new PricesOfProducts();



        public Reports(string name, double totalOliveWeight, double totalObtainedOil, double totalPrice, double totalClaim, double totalSoldOil, double efficiency, int numberOfBeslik,
            int numberOfOnluk, int numberOfOnSekizlik)
        {
            // PROCESS BİLGİ FİŞİ
            pr.LoadPricesFromDatabase();
            this.name = name;
            this.totalOliveWeight = totalOliveWeight;
            this.totalObtainedOil = totalObtainedOil;
            this.totalPrice = totalPrice;
            this.totalClaim = totalClaim;
            this.totalSoldOil = totalSoldOil;
            this.efficiency = efficiency;
            this.numberOfBeslik = numberOfBeslik;
            this.numberOfOnluk = numberOfOnluk;
            this.numberOfOnSekizlik = numberOfOnSekizlik;
        }

        public Reports(string date, double totalOliveWeight, double totalObtainedOil, double totalPrice, double totalClaim, double totalSoldOil, double efficiency)
        {
            // TOPLAM PROCESS RAPORU
            this.date = date;
            this.totalOliveWeight = totalOliveWeight;
            this.totalObtainedOil = totalObtainedOil;
            this.totalPrice = totalPrice;
            this.totalClaim = totalClaim;
            this.totalSoldOil = totalSoldOil;
            this.efficiency = efficiency;
        }


        public Reports(string date, double totalSoldOil, int numberOfBeslik, int numberOfOnluk, int numberOfOnSekizlik, double totalPrice)
        {
            // TOPLAM YAĞ SATIŞ RAPORU
            this.date = date;
            this.totalSoldOil = totalSoldOil;
            this.numberOfBeslik = numberOfBeslik;
            this.numberOfOnluk = numberOfOnluk;
            this.numberOfOnSekizlik = numberOfOnSekizlik;
            this.totalPrice = totalPrice;
        }


        public void PrintProcessReport() // Process günlük rapor
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(DailyProcessReport);
            printDocument.PrinterSettings.PrinterName = "XP-80C";
            printDocument.Print();
        }
        public void PrintProcessReceipt() // Process bilgi fişi
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(ProcessReceipt);
            printDocument.PrinterSettings.PrinterName = "XP-80C";
            printDocument.Print();
        }

        public void PrintSoldOilReport() // Yağ satış günlük rapor
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(DailySoldOilReport);
            printDocument.PrinterSettings.PrinterName = "XP-80C";
            printDocument.Print();
        }
        public void PrintSoldOilReceipt() // Yağ satış bilgi fişi
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(SoldOilReceipt);
            printDocument.PrinterSettings.PrinterName = "XP-80C";
            printDocument.Print();
        }



        public Reports(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void SoldOilReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int yPosition = 10;
            int lineHeight = 20;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12);


            g.DrawString("           MEKECE IŞIK", titleFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight + 5;
            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;


            g.DrawString("           Bilgi Fişi", titleFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;


            g.DrawString($"İsim-Soyisim: {date}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Yağ (KG): {totalSoldOil}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Beşlik: {numberOfBeslik} adet", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Onluk: {numberOfOnluk} adet", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Onsekizlik: {numberOfOnSekizlik} adet", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;

            g.DrawString($"Toplam Ücret: {Math.Round(totalPrice, 1)}", boldFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            //g.DrawString("              0 264 563 55 90", regularFont, Brushes.Black, 0, yPosition);
            g.DrawString("              0 264 517 15 20", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;
            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;

            g.DrawString("Bizi tercih ettiğiniz için teşekkür ederiz", regularFont, Brushes.Black, 0, yPosition);
        }


        private void DailySoldOilReport(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int yPosition = 10;
            int lineHeight = 20;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12);


            g.DrawString("         MEKECE IŞIK", titleFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight + 5;
            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;


            g.DrawString("      Günsonu Raporu", titleFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;


            g.DrawString($"Tarih: {date}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Yağ (KG): {Math.Round(totalSoldOil, 1)}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Beşlik: {numberOfBeslik} adet", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Onluk: {numberOfOnluk} adet", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Onsekizlik: {numberOfOnSekizlik} adet", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;

            g.DrawString($"Toplam Ücret: {Math.Round(totalPrice, 1)}", boldFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;


            g.DrawString("      Günsonu Tamamlandı", titleFont, Brushes.Black, 10, yPosition);
        }




        private void ProcessReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int yPosition = 10;
            int lineHeight = 20;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12);


            g.DrawString("           MEKECE IŞIK", titleFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight + 5;
            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;


            //g.DrawString($"Tarih: {date}", regularFont, Brushes.Black, 10, yPosition);
            //yPosition += lineHeight;
            g.DrawString($"İsim-Soyisim: {name}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"İşlenen Zeytin (KG): {totalOliveWeight}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Çıkan Yağ (KG): {totalObtainedOil}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Ücret: {Math.Round(totalPrice, 1)}", boldFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Hak (KG): {Math.Round(totalClaim, 2)}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satın Alınan Yağ (KG): {totalSoldOil}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Verim: {Math.Round(efficiency, 2)}", boldFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satın Alınan Teneke:", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            if (numberOfBeslik > 0)
            {
                g.DrawString($"Beşlik teneke: {numberOfBeslik} x {pr.PriceOfBeslik} = {numberOfBeslik * pr.PriceOfBeslik} TL", regularFont, Brushes.Black, 10, yPosition);
                yPosition += lineHeight;
            }
            if (numberOfOnluk > 0)
            {
                g.DrawString($"Onluk teneke: {numberOfOnluk} x {pr.PriceOfOnluk} = {numberOfOnluk * pr.PriceOfOnluk} TL", regularFont, Brushes.Black, 10, yPosition);
                yPosition += lineHeight;
            }
            if (numberOfOnSekizlik > 0)
            {
                g.DrawString($"Onseziklik teneke: {numberOfOnSekizlik} x {pr.PriceOfOnSekizlik} = {numberOfOnSekizlik * pr.PriceOfOnSekizlik} TL", regularFont, Brushes.Black, 10, yPosition);
                yPosition += lineHeight;
            }

            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Hak verildiği zaman çıkan yağın %15", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;
            g.DrawString($"i tahsis edilir. Nakit işlemlerde zeytin", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;
            g.DrawString($"kilosunun {pr.ProcessPrice} TL ile çarpımına eşittir.", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;
            //g.DrawString($"               0 264 563 55 90", regularFont, Brushes.Black, 10, yPosition);
            g.DrawString("              0 264 517 15 20", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;
            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;


            g.DrawString("Bizi tercih ettiğiniz için teşekkür ederiz", regularFont, Brushes.Black, 0, yPosition);
        }





        private void DailyProcessReport(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int yPosition = 10;
            int lineHeight = 20;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12);


            g.DrawString("          MEKECE IŞIK", titleFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight + 5;
            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;


            g.DrawString("      Günsonu Raporu", titleFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;


            g.DrawString($"Tarih: {date}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"İşlenen Zeytin (KG): {Math.Round(totalOliveWeight, 1)}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Toplam Çıkan Yağ (KG): {Math.Round(totalObtainedOil, 1)}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Toplam Ücret: {Math.Round(totalPrice, 1)}", boldFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Alınan Hak (KG): {Math.Round(totalClaim, 2)}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Satılan Yağ (KG): {Math.Round(totalSoldOil, 1)}", regularFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString($"Ortalama Verim: {Math.Round(efficiency, 2)}", boldFont, Brushes.Black, 10, yPosition);
            yPosition += lineHeight;
            g.DrawString("--------------------------------------------------", regularFont, Brushes.Black, 0, yPosition);
            yPosition += lineHeight;


            g.DrawString("   Günsonu Tamamlandı", titleFont, Brushes.Black, 10, yPosition);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainPage.Show();
            this.Close();
        }

        private void btn_dailyReport_Click(object sender, EventArgs e)
        {

            clc.CalcDailyTotal();
        }


        private void btn_printReport_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Rapor Tipini Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                if (comboBox1.Text == "Zeytin İşleme Raporu")
                {
                    clc.CalculateTotalsBetweenDates(dateTimePicker1.Value, dateTimePicker2.Value);
                }
                if (comboBox1.Text == "Yağ satışı Raporu")
                {
                    clc.CalcTotalSoldOilBetweenDates(dateTimePicker1.Value, dateTimePicker2.Value);
                }
            }
            
        }

        
    }
}
