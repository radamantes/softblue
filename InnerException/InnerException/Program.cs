using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculador c = new Calculador();
      double result = c.Dividir(10, 0);
      Console.WriteLine(result);
    }
  }

  class Calculador
  {
    public double Dividir(double a, double b)
    {

      try
      {
        Divisao d = new Divisao(a, b);
        return d.Dividir();
      }
      catch (DivisaoException e)
      {
        throw new CaculoException("Erro de Cálculo", e);
      }

    }
  }

  class Divisao
  {
    public double Numerador { get; set; }
    public double Denominador { get; set; }

    public Divisao(double numerador, double denominador)
    {
      this.Numerador = numerador;
      this.Denominador = denominador;
    }

    public double Dividir()
    {
      if (Denominador == 0)
      {
        throw new DivisaoException("Denominador não pode ser zero");
      }
      return Numerador / Denominador;
    }
  }
}
