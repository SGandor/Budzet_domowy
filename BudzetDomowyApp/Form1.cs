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

        private DateTimePicker GetDateTimePicker1()
        {
            return dateTimePicker1;
        }

        private void OdswiezListeTransakcji()
        {
            dataGridView1.DataSource = null; // Resetowanie Ÿród³a danych
            dataGridView1.DataSource = budzet.Transakcje; // Ustawienie nowego Ÿród³a danych
        }



        private void AktualizujStatystyki()
        {
            lblBilans.Text = $"Bilans: {budzet.Bilans()} z³";
            lblPrzychody.Text = $"Przychody: {budzet.SumaPrzychodow()} z³";
            lblWydatki.Text = $"Wydatki: {budzet.SumaWydatkow()} z³";
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
    }
}
