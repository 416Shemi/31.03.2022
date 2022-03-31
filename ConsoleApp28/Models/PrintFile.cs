using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28.Models
{
    class PrintFileGeneric<T>
       where T:IPrintable
    {
      public void Print(T file)
       {
            file.Print();
       }
        
    }
   
}
