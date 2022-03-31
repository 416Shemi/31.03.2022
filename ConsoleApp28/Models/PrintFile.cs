using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28.Models
{
    class PrintFileList<T> : IPrintable
    {
        public string FileName { get; set ; }
        
    }
    static void Print()
    {
        Console.WriteLine("FileName printed");
    }
}
