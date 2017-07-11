using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnacci
{
  class Program
  {
    static void Main(string[] args)
    {
      int a, b;

      int temp = 0;

      a = 1;

      b = 1;
      
      for (int cont = 0; cont < 15; cont++)
      {

        Console.WriteLine(b);

        a = b;

        b += temp;

        temp = a;
      }

      
    }
  }
}
