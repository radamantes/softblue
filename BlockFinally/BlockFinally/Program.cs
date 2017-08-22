using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockFinally
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Executar(true); // QUANDO MUDA PARA TRUE GERA EXCEÇÃO
       
      }
      catch (ArgumentException e)
      {
        Console.WriteLine("Exceção tratada");
      }
      finally // ELE É SEMPRE EXECUTANDO INDEPENDE SE EXISTE EXCEÇÕES OU NÃO
      {
        Console.WriteLine("Aplicação terminada");
      }

    }

    static void Executar(bool b)
    {
      if (b)
      {
        throw new ArgumentException();
      }
    }
  }
}
