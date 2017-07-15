using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
  class Trapezio
  {
    public double baseMaior;
    public double baseMenor;
    public double altura;

    public double CalcularArea()
    {
      return ((baseMaior + baseMenor) / 2) * altura;
    }
  }
}
