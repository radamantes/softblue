using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
       Verifique a validade de uma data e mostre uma mensagem na tela dizendo se a data é válida ou
      inválida. Devem existir três variáveis para armazenar o dia, o mês e o ano, e o usuário deve
      fornecer os valores para estas variáveis via console. Considerar que fevereiro pode ter
      somente 28 dias e que anos válidos estão compreendidos entre 1900 e 2999.
       */

      int mes = 0, ano, dia;
      string verificaAno = String.Empty;
      bool verificaMes;


      Console.WriteLine("Digite o dia: ");
      dia = int.Parse(Console.ReadLine());

      
      while (true)
      {
        Console.WriteLine("Digite o mês");
        mes = int.Parse(Console.ReadLine());

        if (mes == 2 && dia > 28)
        {          
          verificaMes = false;
          Console.WriteLine("Dia inválido para o mês de fevereiro");
        }
        else
        { 
          // SAI DO LOOK WHILE QUANDO O MÊS É IGUAL A FEVEREIRO E TEM ATÉ 28  DIAS
          verificaMes = true;
          break;

        }
      }

      Console.WriteLine("Digite o ano");
      ano = int.Parse(Console.ReadLine());

      if (ano < 1900 || ano > 2999)
      {
        verificaAno = "Data Inválida";
      }
      else
      {
        verificaAno = "Data válida";
      }

      Console.WriteLine(verificaAno + " Data: " + dia + "/" + mes + "/"  + ano);
      
    }
  }
}
