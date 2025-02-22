using System;

public class Wydatek : Transakcja
{
    public Wydatek(DateTime data, decimal kwota, string opis, string kategoria)
    {
        Data = data;
        Kwota = kwota;
        Opis = opis;
        Kategoria = kategoria;
        Typ = "Wydatek";
    }
}