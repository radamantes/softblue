using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConvertDelegateLambda
{
  class Program
  {

    static void Main(string[] args)
    {
      //USANDO DELEGATE ANONIMO

      //Converter converter = delegate (double n)
      //{
      //  return n / 2;
      //};

      //List<double> newList = ConvertAll(converter);

      //USANDO LAMBDA
      List<double> newList = ConvertAll(x => x / 2);


      foreach (var item in newList)
      {
        Action a = () => Console.WriteLine(item);
        a();
      }
    }

    static List<double> ConvertAll(Converter handler)
    {
      List<double> lista = new List<double> { 3, 7, 2, 4, 6 };

      List<double> newList = new List<double>();


      foreach (var item in lista)
      {
        double n = handler(item);
        newList.Add(n);
      }

      return newList;
    }
  }
  public delegate double Converter(double n);
}
