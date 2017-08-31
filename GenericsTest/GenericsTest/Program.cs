using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
  class Program
  {

    static void Main(string[] args)
    {
      Lista<int> l = new Lista<int>();

      l.Adicionar(10);
      l.Adicionar(20);
      l.Adicionar(30);


      int i2 = (int)l.Ler(2);

      Console.WriteLine(i2);

    }
  }
}
