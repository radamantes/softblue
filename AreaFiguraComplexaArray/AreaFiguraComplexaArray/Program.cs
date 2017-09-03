using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFiguraComplexaArray
{
  class Program
  {
    static void Main(string[] args)
    {

      //CRIEI 2 QUADRADOS 
      Quadrado q1 = new Quadrado(3);
      Quadrado q2 = new Quadrado(10);

      //CRIEI 2 RETANGULOS
      Retangulo r1 = new Retangulo(2, 7);
      Retangulo r2 = new Retangulo(5, 3);

      //CRIA UM ARRAY DE FIGUROS
      Figura[] figuras =  { q1, q2, r1, r2, };

      // Constroi uma figura complexa com base nas figuras criadas anteriormente
      FiguraComplexa fc = new FiguraComplexa(figuras);

      Console.WriteLine(fc.CalcularArea());


    }
  }
  public abstract class Figura
  {
    public abstract double CalcularArea();
  }

  //RETANGULO
  public class Retangulo : Figura
  {
    private double @base;
    private double altura;
    // Construtor que recebe a base e a altura como parâmetros
    public Retangulo(double @base, double altura)
    {
      this.@base = @base;
      this.altura = altura;
    }
    // Método sobrescrito para calcular a área do retângulo
    public override double CalcularArea()
    {
      return @base * altura;
    }
  }
  //QUADRADO
  public class Quadrado : Figura
  {
    private double lado;

    public Quadrado(double lado)
    {
      this.lado = lado;
    }

    public override double CalcularArea()
    {
      return lado * lado;
    }
  }
  public class FiguraComplexa : Figura
  {
    public Figura[] figuras;

    public FiguraComplexa(Figura[] figuras)
    {
      this.figuras = figuras;
    }

    // Método sobrescrito para calcular a área total da figura.
    // A área total é a soma das áreas de todas as figuras.
    public override double CalcularArea()
    {
      double areaTotal = 0;
           
      for (int i = 0; i < figuras.Length; i++)
      {
        //aqui entra uma parte do polimorfismo, dependendo da figura que está no vetor ele irá chamar o método calcularArea correspondente a ela.
        areaTotal += figuras[i].CalcularArea(); 
      }
      return areaTotal;
    }
  }
}
