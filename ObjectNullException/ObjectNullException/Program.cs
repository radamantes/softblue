using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectNullException
{
  class Program
  {
    static void Main(string[] args)
    {

      // Declara um objeto nulo
      object o = null;

      try
      {
        
        // Ao chamar este método o C# irá lançar uma NullReferenceException
        o.ToString();
      }
      catch (NullReferenceException)
      {
        // Faz um catch da exceção e mostra uma mensagem amigável
        Console.WriteLine("O método está sendo chamado em um objeto nulo, o que não é permitido"); ;
      }

      // Como a exceção foi tratada, o código continua normalmente, mostra a mensagem 
      // abaixo e termina
      Console.WriteLine("Fim do programa");

    }
  }
}
