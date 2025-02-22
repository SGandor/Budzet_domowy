using ClosedXML.Excel;
using System;
using System.Collections.Generic;

namespace BudzetDomowy
{
    public class ExcelTabela : IExporter
    {
        public void ExportToExcel(List<Transakcja> transakcje, string filePath)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Transakcje");

            worksheet.Cell(1, 1).Value = "Data";
            worksheet.Cell(1, 2).Value = "Kwota";
            worksheet.Cell(1, 3).Value = "Opis";
            worksheet.Cell(1, 4).Value = "Kategoria";
            worksheet.Cell(1, 5).Value = "Typ";

            for (int i = 0; i < transakcje.Count; i++)
            {
                var transakcja = transakcje[i];
                worksheet.Cell(i + 2, 1).Value = transakcja.Data.ToString("yyyy-MM-dd");
                worksheet.Cell(i + 2, 2).Value = transakcja.Kwota;
                worksheet.Cell(i + 2, 3).Value = transakcja.Opis;
                worksheet.Cell(i + 2, 4).Value = transakcja.Kategoria;
                worksheet.Cell(i + 2, 5).Value = transakcja.TypTransakcji.ToString();
            }

            workbook.SaveAs(filePath);
        }
    }
}
