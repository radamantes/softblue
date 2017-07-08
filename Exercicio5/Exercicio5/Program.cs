using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
  class Program
  {
    static void Main(string[] args)
    { /*
      Imprima os 15 primeiros números da série de Fibonacci. A série de Fibonacci possui a seguinte
      sequência numérica: 0, 1, 1, 2, 3, 5, 8, 13, 21, etc.
      Para calculá-la, o primeiro e segundo elementos valem 1, daí por diante, o n-ésimo elemento
      vale o (n-1)-ésimo elemento somado ao (n-2)-ésimo elemento (ex: 8 = 5 + 3). Para mais
      informações, consulte: http://pt.wikipedia.org/wiki/Número_de_Fibonacci.
      */


      for (int y = 1, x = 0; y <= 100; y = y)
      {
        y = y + x;
        x = y - x;
        Console.WriteLine(y);
      }
    }
  }
}
