using ClosedXML.Excel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BudzetDomowyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Budzet budzet = new Budzet();

        private void btnEksport_Click(object sender, EventArgs e)
        {
            ExcelTabela.EksportujDoExcel(budzet.Transakcje, "budzet.xlsx");
            MessageBox.Show("Dane zosta�y wyeksportowane do pliku 'budzet.xlsx'!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ustawienie listy typ�w transakcji
            cmbTyp.Items.Add("Przych�d");
            cmbTyp.Items.Add("Wydatek");
            cmbTyp.SelectedIndex = 0; // Domy�lnie zaznaczony pierwszy element

            // Ustawienie kategorii
            cmbKategoria.Items.AddRange(new string[]
            {
        "Jedzenie",
        "Transport",
        "Rozrywka",
        "Rachunki",
        "Wynagrodzenie",
        "Inne"
            });
            cmbKategoria.SelectedIndex = 0; // Domy�lnie zaznaczona pierwsza kategoria
        }

        private void Dodaj_transakcje_Click(object sender, EventArgs e)
        {
            try
            {
                Transakcja transakcja;

                // Sprawdzenie, jaki typ transakcji zosta� wybrany
                if (cmbTyp.SelectedItem.ToString() == "Przych�d")
                {
                    transakcja = new Przychod();
                }
                else
                {
                    transakcja = new Wydatek();
                }

                // Pobieranie danych z formularza
                transakcja.Data = dateTimePicker1.Value;
                transakcja.Kwota = decimal.Parse(txtKwota.Text);
                transakcja.Nazwa = txtNazwa.Text;
                transakcja.Opis = txtOpis.Text;
                transakcja.Kategoria = cmbKategoria.SelectedItem.ToString();

                // Dodanie transakcji do bud�etu
                budzet.DodajTransakcje(transakcja);

                // Od�wie�enie widoku listy
                OdswiezListeTransakcji();
                AktualizujStatystyki();

                // Czyszczenie p�l po dodaniu
                txtNazwa.Clear();
                txtOpis.Clear();
                txtKwota.Clear();
                cmbTyp.SelectedIndex = 0;
                cmbKategoria.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B��d podczas dodawania transakcji: {ex.Message}");
            }
        }

        private DateTimePicker GetDateTimePicker1()
        {
            return dateTimePicker1;
        }

        private void OdswiezListeTransakcji()
        {
            dataGridView1.DataSource = null; // Resetowanie �r�d�a danych
            dataGridView1.DataSource = budzet.Transakcje; // Ustawienie nowego �r�d�a danych
        }



        private void AktualizujStatystyki()
        {
            lblBilans.Text = $"Bilans: {budzet.Bilans()} z�";
            lblPrzychody.Text = $"Przychody: {budzet.SumaPrzychodow()} z�";
            lblWydatki.Text = $"Wydatki: {budzet.SumaWydatkow()} z�";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Wybierz plik Excel do zaimportowania"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportujZExcel(filePath);  // Wywo�anie metody importu
            }

        }

        private void ImportujZExcel(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik nie istnieje.");
                return;
            }

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // Pierwszy arkusz
                var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Pomija nag��wek

                foreach (var row in rows)
                {
                    try
                    {
                        Transakcja transakcja;
                        string typ = row.Cell(5).GetString();

                        if (typ == "Przych�d")
                            transakcja = new Przychod();
                        else
                            transakcja = new Wydatek();

                        transakcja.Data = row.Cell(1).GetDateTime();
                        transakcja.Kwota = decimal.Parse(row.Cell(2).GetString());
                        transakcja.Nazwa = row.Cell(3).GetString();
                        transakcja.Opis = row.Cell(4).GetString();
                        transakcja.Kategoria = row.Cell(6).GetString();

                        budzet.DodajTransakcje(transakcja);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"B��d podczas importu: {ex.Message}");
                    }
                }
            }

            OdswiezListeTransakcji();
            AktualizujStatystyki();
            MessageBox.Show("Dane zosta�y zaimportowane!");
        }

    }
}
