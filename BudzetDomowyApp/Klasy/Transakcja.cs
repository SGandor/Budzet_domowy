using System;

public class Transakcja
{
	public DateTime Data { get; set; }
	public decimal Kwota { get; set; }
	public string Opis { get; set; }
	public string Kategoria { get; set; } // np. jedzenie, transport, mieszkanie, oplaty
	public string Typ { get; set; } // przychod, wydatek
}
