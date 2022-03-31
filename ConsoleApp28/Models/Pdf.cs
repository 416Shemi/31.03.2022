using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28.Models
{
    class Pdf : IPrintable
    {
        public string FileName { get ; set; }
        public int PageCount { get; set; }
        public Pdf(string fileName, int pageCount)
        {
            FileName = fileName;
            PageCount = pageCount;
        }
       public void Print(string FileName, int PageCount)
        {
            Console.WriteLine($"FileName:{FileName} PageCount{PageCount}");
        }
    }
}
