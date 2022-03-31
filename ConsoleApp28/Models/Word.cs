using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28.Models
{
    class Word : IPrintable
    {
        public string FileName { get ; set; }
        public int WordCount { get; set; }
        public Word(string fileName, int wordCount)
        {
            FileName = fileName;
            WordCount = wordCount;
        }
        static void Print()
        {
            Console.WriteLine("FileName printed");
        }
    }
}
