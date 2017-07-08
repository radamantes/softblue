using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      //Escreva um programa que calcule o fatorial de 10.Regra: FATORIAL DE 5 = 5= 5*4*3*2*1

      int fat = 10;

      for (int cont = 1; cont < 10; cont++)
      {
        fat *= cont;
        Console.WriteLine(fat);
      }
      Console.WriteLine("O Fatorial de 10 é: "+ fat);

    }
  }
}
