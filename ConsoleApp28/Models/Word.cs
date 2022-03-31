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
        public void Print(string FileName, int WordCount)
        {
            Console.WriteLine($"FileName:{FileName} WordCount:{WordCount}");
        }
    }
}
