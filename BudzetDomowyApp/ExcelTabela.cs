using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace BudzetDomowyApp
{
    public class ExcelTabela
    {
        public static void EksportujDoExcel(List<Transakcja> transakcje, string sciezka)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Transakcje");

            worksheet.Cell(1, 1).Value = "Data";
            worksheet.Cell(1, 2).Value = "Kwota";
            worksheet.Cell(1, 3).Value = "Nazwa";
            worksheet.Cell(1, 4).Value = "Opis";
            worksheet.Cell(1, 5).Value = "Kategoria";
            worksheet.Cell(1, 6).Value = "Typ";

            for (int i = 0; i < transakcje.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = transakcje[i].Data;
                worksheet.Cell(i + 2, 2).Value = transakcje[i].Kwota;
                worksheet.Cell(i + 2, 3).Value = transakcje[i].Nazwa;
                worksheet.Cell(i + 2, 4).Value = transakcje[i].Opis;
                worksheet.Cell(i + 2, 5).Value = transakcje[i].Kategoria;
                worksheet.Cell(i + 2, 6).Value = transakcje[i].Typ;
            }

            workbook.SaveAs(sciezka);
        }
    }
}
