using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      //imprimindo números de 10 a 25
      /*
       for(int x = 10; x <=25; x++)
      {
        Console.WriteLine(x);
      }
      */

      //Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.).
      /*
       * int soma = 1;
      for (int cont = 1; cont <=100; cont++)
      {
               
        Console.WriteLine(soma);
        soma = soma + 2;

      }
      Console.WriteLine(soma);
      */

      //3. Começando em 0, imprima os números seguintes, enquanto a soma dos números já impressos for menor que 100.
      /*
      int soma = 0;
      int cont = 0;


      while (soma < 100)
      {
        Console.WriteLine(soma);
        soma += cont;
        cont++;
      }
      
       */

      //Imprima a tabuada do 9 (até o décimo valor).

      int valor = 9;
      for(int cont = 1; cont <=9; cont++)
      {       
        Console.WriteLine(valor +  " x "+  cont + " = " + valor*cont  ); 
      }
    }
  }
}

