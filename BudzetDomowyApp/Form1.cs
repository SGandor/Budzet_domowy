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

    }
}
