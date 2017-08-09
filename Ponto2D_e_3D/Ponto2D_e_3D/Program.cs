using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto2D_e_3D
{
  class Program
  {
    static void Main(string[] args)
    {
      Ponto2D p2 = new Ponto2D(10, 2);
      p2.Imprimir();


      int resultado = (1 * 1) + 1 * 2;

      Console.WriteLine(resultado);



      Ponto3D p3 = new Ponto3D(6, 7, 8);
      p3.Imprimir();

    }

  }
}
