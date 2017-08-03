using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto2D_e_3D
{
  class Ponto2D : Imprimir
  {
    private double x;
    private double y;

    public double X
    {
      get { return x; }
    }

    public double Y
    {
      get { return y; }
    }

    public Ponto2D(double x, double y)
    {
      this.x = x;
      this.y = y;
    }

    public void Imprimir()
    {
      Console.WriteLine("Valor de X = " + x + " Valor de Y = " + y );
    }
  }

}
