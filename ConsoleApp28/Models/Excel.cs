using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28.Models
{
    class Excel : IPrintable
    {
        public string FileName { get ; set; }
        public int ColumnCaunt { get; set; }
        public int RowCaunt { get; set; }
        public Excel(string fileName, int columnCaunt, int cowCaunt)
        {
            FileName = fileName;
            ColumnCaunt = columnCaunt;
            RowCaunt = cowCaunt;
        }
        public void Print( string FileName, int ColumnCaunt, int RowCaunt)
        {
            Console.WriteLine($"FileName:{FileName} ColumnCaunt:{ColumnCaunt} RowCaunt:{RowCaunt}");
        }
    }
}
