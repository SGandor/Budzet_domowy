using System;

public class Budzet
{
	public List<Transakcja> Transakcje { get; set; }

	public Budzet()
	{
		Transakcje = new List<Transakcja>();
	}

	public void DodajTransakcje(Transakcja transakcja)
	{
		Transakcje.Add(transakcja);
	}

	public void UsunTransakcje(Transakcja transakcja)
	{
		Transakcje.Remove(transakcja);
	}

	public decimal SumaPrzychodow()
	{
		return Transakcje.Where(testc => testc.Typ == "Przychod").Sum(testc => testc.Kwota);
	}

	public decimal SumaWydatkow()
	{
		return Transakcje.Where(testc => testc.Typ == "Wydatek").Sum(testc => testc.Kwota);
	}

	public decimal Bilans()
	{
		return SumaPrzychodow() - SumaWydatkow();
	}
}
