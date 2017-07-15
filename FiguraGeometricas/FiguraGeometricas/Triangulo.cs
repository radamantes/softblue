using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
  class Triangulo
  {
    public int @base;
    public int altura;

    //public Triangulo()
    //{
    //  @base = 10;
    //  altura = 5;
    //}

    public double CalcularArea()
    {
      return (@base * altura) / 2;
    }
  }
}
