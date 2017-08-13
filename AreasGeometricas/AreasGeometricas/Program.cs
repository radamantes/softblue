using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasGeometricas
{
  class Program
  {
    static void Main(string[] args)
    {
      Retangulo r = new Retangulo(5, 7);
      double areaRetangulo = r.CalcularArea();
      Console.WriteLine("Área do Retângulo é: " + areaRetangulo);

      Circunferencia c = new Circunferencia(5);
      double areaCircufenrencia = c.CalcularArea();
      Console.WriteLine("Área da Circunferência é: " + areaCircufenrencia);

      Quadrado q = new Quadrado(7);
      double areaQuadrado = q.CalcularArea();
      Console.WriteLine("Área do Quadrado é: " + areaQuadrado);
    }
  }

  interface IAreaCalculavel
  {
    double CalcularArea();
  }

  class Quadrado : IAreaCalculavel
  {
    double lado;

    public Quadrado(double lado)
    {
      this.lado = lado;
    }

    public double CalcularArea()
    {
      return lado * lado;
    }
  }
  //AREA DO RETANGULO É CALCULADA PELA BASE X ALTURA
  class Retangulo : IAreaCalculavel
  {
    double @base;
    double altura;

    public Retangulo(double @base, double altura)
    {
      this.@base = @base;
      this.altura = altura;
    }

    public double CalcularArea()
    {
      return @base * altura;
    }
  }
  //AREA DA CIRCUNFERENCIA É PI X R ELEVANDO A SEGUNDA POTÊNCIA
  class Circunferencia : IAreaCalculavel
  {
    double raio;

    public Circunferencia(double raio)
    {
      this.raio = raio;
    }

    public double CalcularArea()
    {
      return Math.PI * Math.Pow(raio, 2); //calculo raiudo elevado ao quadrado depois multiplica por PI
    }
  }
}
