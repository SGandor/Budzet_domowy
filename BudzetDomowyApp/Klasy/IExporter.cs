using System;
using System.Collections.Generic;

namespace BudzetDomowy
{
    public interface IExporter
    {
        void ExportToExcel(List<Transakcja> transakcje, string filePath);
    }
}
