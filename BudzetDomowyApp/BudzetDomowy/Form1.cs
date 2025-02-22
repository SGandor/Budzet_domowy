using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudzetDomowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicjalizacja formularza
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dzia³a!");
        }

        // Przyk³adowe transakcje
        var transakcje = new List<Transakcja>
            {
                new Transakcja
                {
                    Data = DateTime.Now,
                    Kwota = 100.0m,
                    Opis = "Zakup jedzenia",
                    Kategoria = "Jedzenie",
                    TypTransakcji = TypTransakcji.Wydatek
                },
                new Transakcja
                {
                    Data = DateTime.Now,
                    Kwota = 200.0m,
                    Opis = "Przychód z pracy",
                    Kategoria = "Przychód",
                    TypTransakcji = TypTransakcji.Przychod
                }
            };

            var excelTabela = new ExcelTabela();
            excelTabela.ExportToExcel(transakcje, @"C:\Users\...\Budzet.xlsx");

            MessageBox.Show("Eksport zakoñczony!");
        }
    }
}
