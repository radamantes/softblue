using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
  class Program
  {
    static void Main(string[] args)
    {

      /*Escreva um programa que imprime na saída os valores assumidos por x. Esta variável x deve
        iniciar com algum valor inteiro, fornecido pelo usuário.Se x for par, x deve receber o valor
        dele mesmo somado com 5.Já se x for ímpar, x deve receber o valor dele multiplicado por 2.
        O programa termina assim que x for maior que 1000.Por exemplo, para x = 10, a saída deve
        ser: 15, 30, 35, 70, 75, 150, 155, 310, 315, 630, 635, 1270.Faça este exercício usando blocos if
        e depois usando blocos switch.
        Dica: Para ler o número inteiro via console e convertê - lo para int, você pode utilizar:
      */

      /*
       
      //AQUI FIZ COM O IF
    
      int numero;
      numero = int.Parse(Console.ReadLine());
      while ( numero < 1000)
      {      

        //AQUI VERIFIVA SE O NÚMERO É BAR
        if(numero %2 == 0)
        {
          //NUMERO RECEBE NUMERO  +5
          numero +=  5;
          Console.WriteLine(numero);
        }
        
        else if( numero % 2 != 0)
        {
          //NUMERO RECEBE NUMERO MULTIPLICADO POR 2
          numero *= 2;
          Console.WriteLine(numero);
        }
       
      }
      */
      // ------------------------------------------------------------------------------------------------------//

      //SÃO DOIS ALGORITMOS DIFERENTE PORÉM OS RESULTADOS SÃO OS MESMOS.
      //AQUI UTILIZEI BLOCK SWITCH
      
      bool definicao = true;
      int numero = int.Parse(Console.ReadLine());


      while (numero < 1000)
      {
        
        if (numero % 2 == 0)
        {
          definicao = true;
        }
        else
        {
          definicao = false;
        }

        switch (definicao)
        {
          case true:
            numero += 5;
            Console.WriteLine(numero);
            break;

          case false:
            numero *= 2;
            Console.WriteLine(numero);
            break;
        }
      }

    }
  }
}
