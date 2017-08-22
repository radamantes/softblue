using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateException
{
  class Program
  {

    static void Main(string[] args)
    {
      ContaCorrente c = new ContaCorrente();

      try
      {
        c.Depositar(200);
        c.Sacar(250);
      }
      catch (ContaCorrenteException e)
      {
        Console.WriteLine("ERRO");
        Console.WriteLine("Mensagem: " + e.Message);
        Console.WriteLine("Local : " + e.TargetSite);
        Console.WriteLine("StackTrace: " + e.StackTrace);
      }

    }
  }
}