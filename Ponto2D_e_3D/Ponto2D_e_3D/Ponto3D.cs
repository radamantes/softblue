using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto2D_e_3D
{
  class Ponto3D : Ponto2D, Imprimir
  {
    private double z;

    
    public Ponto3D(double x, double y, double z) : base(x, y)
    {
      this.z = z;
    }

    public void Imprimir()
    {
      Console.WriteLine("Valor de X = " + X + " Valor de Y = " + Y + " Valor de Z é " + z);
    }
  }
}
