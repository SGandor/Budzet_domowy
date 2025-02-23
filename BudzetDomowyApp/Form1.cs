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
            budzet.DodajTransakcje(new Przychod
            {
                Data = DateTime.Now,
                Kwota = 5000,
                Nazwa = "Wyp³ata",
                Opis = "Miesiêczna wyp³ata",
                Kategoria = "Praca"
            });

            budzet.DodajTransakcje(new Wydatek
            {
                Data = DateTime.Now,
                Kwota = 200,
                Nazwa = "Zakupy",
                Opis = "Codzienne zakupy",
                Kategoria = "Jedzenie"
            });

            ExcelTabela.EksportujDoExcel(budzet.Transakcje, "budzet.xlsx");
            MessageBox.Show("Dane zosta³y wyeksportowane do pliku 'budzet.xlsx'!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ustawienie listy typów transakcji
            cmbTyp.Items.Add("Przychód");
            cmbTyp.Items.Add("Wydatek");
            cmbTyp.SelectedIndex = 0; // Domyœlnie zaznaczony pierwszy element

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
            cmbKategoria.SelectedIndex = 0; // Domyœlnie zaznaczona pierwsza kategoria
        }

        private void Dodaj_transakcje_Click(object sender, EventArgs e)
        {
            try
            {
                Transakcja transakcja;

                // Sprawdzenie, jaki typ transakcji zosta³ wybrany
                if (cmbTyp.SelectedItem.ToString() == "Przychód")
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

                // Dodanie transakcji do bud¿etu
                budzet.DodajTransakcje(transakcja);

                // Odœwie¿enie widoku listy
                OdswiezListeTransakcji();
                AktualizujStatystyki();

                // Czyszczenie pól po dodaniu
                txtNazwa.Clear();
                txtOpis.Clear();
                txtKwota.Clear();
                cmbTyp.SelectedIndex = 0;
                cmbKategoria.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d podczas dodawania transakcji: {ex.Message}");
            }
        }

        private void OdswiezListeTransakcji()
        {
            dateTimePicker1.DataSource = null;
            dateTimePicker1.DataSource = budzet.Transakcje;
        }

        private void AktualizujStatystyki()
        {
            lblBilans.Text = $"Bilans: {budzet.Bilans()} z³";
            lblPrzychody.Text = $"Przychody: {budzet.SumaPrzychodow()} z³";
            lblWydatki.Text = $"Wydatki: {budzet.SumaWydatkow()} z³";
        }

    }
}
