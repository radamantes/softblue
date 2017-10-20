using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObsoleteSystemDLL
{
  class Program
  {
    static void Main(string[] args)
    {


      // Obtém o assembly System.dll.
      Assembly assembly = Assembly.GetAssembly(typeof(object));

      // Itera sobre todos os tipos definidos no assembly.
      foreach (var type in assembly.GetTypes())
      {
        // Se o tipo for uma classe e tiver o atributo [Obsolete] definido, mostra na tela.
        if (type.GetCustomAttribute<ObsoleteAttribute>() != null && type.IsClass)
        {
          Console.WriteLine(type.FullName);
        }
      }

      Console.WriteLine("----------------------------------------------------------------------------------------");

      // Itera sobre todos os tipos definidos no assembly.
      foreach (var item in assembly.GetTypes())
      {
        if (item.IsClass) // Se o tipo for uma classe, itera sobre os métodos.
        {
          foreach (var method in item.GetMethods())
          {
            // Se o método tiver o atributo [Obsolete] definido, mostra na tela as informações do método (nome e classe que o definiu).
            if (method.GetCustomAttribute<ObsoleteAttribute>() != null)
            {
              Console.WriteLine("{0}() -> {1}", method.Name, method.DeclaringType.FullName);
            }
          }
        }
      }
    }
  }
}


