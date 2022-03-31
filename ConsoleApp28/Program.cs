using System;
using ConsoleApp28.Models;

namespace ConsoleApp28
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Excel excel = new Excel("txt", 12, 100);
            Word word = new Word("Word", 120);
            Pdf pdf = new Pdf("pdf", 230);
            PrintFileGeneric<Word> printFileGeneric = new PrintFileGeneric<Word>();
            PrintFileGeneric<Pdf> printFileGeneric1 = new PrintFileGeneric<Pdf>();
            PrintFileGeneric<Excel> printFileGeneric2 = new PrintFileGeneric<Excel>();

            printFileGeneric.Print(word);
            printFileGeneric1.Print(pdf);
            printFileGeneric2.Print(excel);


        }
    }
}
