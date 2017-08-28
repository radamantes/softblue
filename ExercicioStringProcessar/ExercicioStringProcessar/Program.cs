using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioStringProcessar
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine(Processar(null));
      Console.WriteLine(Processar("sss"));
      Console.WriteLine(Processar("abdgheh"));

    }

    public static string Processar(string s)
    {
      // Se a string é nula, retorna null
      if (s == null)
      {
        return null;
      }

      // Converte a string para maiúscula
      if (s.Length <= 3)
      {
        return s.ToUpper();
      }


      // Se o tamanho for maior que 3, substitui os 3 primeiros caracteres por '???'
      if (s.Length >= 3)
      {
        return "???" + s.Substring(3).ToUpper(); //PEGA A PARTIR DO 3 CARACTERE E CONVERTE TAMBÉM  PARA MAIÚSCULA
      }
      return null;
    }
  }
}
