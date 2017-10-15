using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaCalculoIMC
{
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa p = new Pessoa() { Altura = 1.72, Peso = 63 };
   
      //aqui significa 2 parâmetros(x,y) sendo paassados para o método CalculaIMC QUE ESTÁ ATRELADO NO Método Calcula
      double result = p.Calcula((x,y) =>  x / (y * y)); //X = ALTURA Y = PESO
      
      Console.WriteLine(result);

    }

    static double CalculoIMC(double peso, double altura)
    {
      return peso / (altura * altura);
    }
  }

  public delegate double Calculo(double valor1, double valor2);


  public class Pessoa
  {
    public double Peso { get; set; }
    public double Altura { get; set; }

    public double Calcula(Calculo calculo)
    {
      return calculo(Peso, Altura);
    }

  }
}
