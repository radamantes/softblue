using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
  class Quadrado
  {
    public int lado;
    public double area;

    public double CalcularArea()
    {
      return area = Math.Pow(lado, 2); //ELEVANDO AO QUADRADO
    }
  }
}
