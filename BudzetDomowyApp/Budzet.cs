using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowyApp
{
    public class Budzet
    {
        public List<Transakcja> Transakcje { get; set; } = new List<Transakcja>();

        public void DodajTransakcje(Transakcja transakcja) => Transakcje.Add(transakcja);

        public void UsunTransakcje(Transakcja transakcja) => Transakcje.Remove(transakcja);

        public decimal SumaPrzychodow() => Transakcje.Where(t => t.Typ == "Przychód").Sum(t => t.Kwota);

        public decimal SumaWydatkow() => Transakcje.Where(t => t.Typ == "Wydatek").Sum(t => t.Kwota);

        public decimal Bilans() => SumaPrzychodow() - SumaWydatkow();
    }
}
