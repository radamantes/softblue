using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometricas
{
  class Program
  {
    static void Main(string[] args)
    {

      //CALCULANDO A ÁREA DO TRIÂNGULO
      Triangulo triangle = new Triangulo();
      triangle.altura = 12;
      triangle.@base = 5;
      double areaTriangulo = triangle.CalcularArea();
      Console.WriteLine("Cálculo da área do Triângulo é : " + areaTriangulo);


      //CALCULANDO A ÁREA DO QUADRADO
      Quadrado square = new Quadrado();
      square.lado = 8;
      double areaQuadrado = square.CalcularArea();
      Console.WriteLine("Cálculo da área do Quadrado é : " + areaQuadrado);


      //CALCULANDO A CIRCUNFERÊNCIA
      Circunferencia circumference = new Circunferencia();
      circumference.raio = 7;
      double areaCircumferencia = circumference.CalcularArea();
      Console.WriteLine("Cálculo da área da Circumferência é : " + areaCircumferencia);

      //CALCULANDO TRAPEZIO
      Trapezio trapeze = new Trapezio();
      trapeze.altura = 4;
      trapeze.baseMaior = 10;
      trapeze.baseMenor = 20;
      double areaTrapeze = trapeze.CalcularArea();
      Console.WriteLine("Cálculo da área do Trapézio é : " + areaTrapeze);
      
    }
  }
}
