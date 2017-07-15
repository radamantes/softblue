using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
  class Circunferencia
  {
    readonly double PI = Math.PI;
    public double raio;

    public double CalcularArea()
    {
      return PI * Math.Pow(raio,2);
    }
  }
}
