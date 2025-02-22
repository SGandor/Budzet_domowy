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

            int row = 2;
            foreach (var transakcja in transakcje)
            {
                worksheet.Cell(row, 1).Value = transakcja.Data.ToString("yyyy-MM-dd");
                worksheet.Cell(row, 2).Value = transakcja.Kwota;
                worksheet.Cell(row, 3).Value = transakcja.Opis;
                worksheet.Cell(row, 4).Value = transakcja.Kategoria;
                worksheet.Cell(row, 5).Value = transakcja.Typ.ToString();
                row++;
            }

            workbook.SaveAs(filePath);
        }
    }
}
