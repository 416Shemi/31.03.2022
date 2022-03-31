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
        static void Print()
        {
            Console.WriteLine("FileName printed");
        }
    }
}
