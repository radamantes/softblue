using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConvertLambda
{
  class Program
  {
    static void Main(string[] args)
    {
      List<double> lista = new List<double>() { 5, 7, 3, 2, 6, 18 };

      List<double> newList = lista.ConvertAll(x => x / 2);

      newList.ForEach(e => Console.WriteLine(e));

    }
  }
}
