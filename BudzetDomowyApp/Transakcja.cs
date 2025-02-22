using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowyApp
{
    public class Transakcja
    {
        public DateTime Data { get; set; }
        public decimal Kwota { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Kategoria { get; set; }
        public string Typ { get; set; }  // "Przychód" lub "Wydatek"
    }
}
