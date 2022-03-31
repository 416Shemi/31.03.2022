using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28.Models
{
    class Pdf : IPrintable
    {
        public string FileName { get ; set; }
        public string PageCount { get; set; }
        public Pdf(string fileName, string pageCount)
        {
            FileName = fileName;
            PageCount = pageCount;
        }
        static void Print()
        {
            Console.WriteLine("FileName printed");
        }
    }
}
