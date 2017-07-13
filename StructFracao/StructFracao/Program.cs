using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructFracao
{
  /*Crie a estrutura (struct) Fracao, que representa uma fração matemática. Esta estrutura deve
    ser capaz de armazenar o numerador e o denominador da fração. Ela ainda deve ter um
    método que recebe uma fração como parâmetro, multiplica ambas as frações, e retorna uma
    nova fração como resultado. Crie um programa simples que instancia duas frações, define
    seus valores, calcula o valor da multiplicação entre elas e mostra o resultado.*/

  class Program
  {


    static void Main(string[] args)
    {


      Fracao f1 = new Fracao();
      Fracao f2 = new Fracao();

      Fracao resultado;

      int resultadoDivisao;

      //f1.numerador = 10;
      //f1.denominador = 2;

      //f2.numerador = 5;
      //f2.denominador = 3;

      f1.DefinirValoresFracoes(5, 3);
      f2.DefinirValoresFracoes(10, 2);

      //RETONA UMA NOVA FRAÇÃO QUE FOI MULTIPLICADO NO CASO 5X10 3X7  50/21 
      resultado = f1.MultiplicaFracao(f1, f2);

      resultadoDivisao = resultado.CalculaDivisao();

      //FIZ SOMENTE PARA TESTE
      //Console.WriteLine(f2.CalculaDivisao()); 

      Console.WriteLine("Fração " + resultado.numerador + "/"+ resultado.denominador);

      Console.WriteLine("Resultado da Divisão da Fração é : " + resultadoDivisao);

    }

    public struct Fracao
    {
      public int numerador;
      public int denominador;


      //RETORNA A FRAÇÃO MULTIPLICADA 
      public Fracao MultiplicaFracao(Fracao pFracao1, Fracao pFracao2)
      {
        Fracao result;

        result.numerador = pFracao1.numerador * pFracao2.numerador;
        result.denominador = pFracao1.denominador * pFracao2.denominador;

        return result;
      }

      //Calcula Divisão da Fração
      public int CalculaDivisao()
      {

        // Para calcular o valor, basta dividir o numerador da fração pelo denominador. Se o denominador 
        // for 0, o resultado é assumido como 0, já que não é possível fazer uma divisão por 0.
        if (denominador == 0)
        {
          return 0;
        }

        return numerador / denominador;
      }

      //DEFININDO OS VALORES DAS FRAÇÕES
      public void DefinirValoresFracoes(int numerador, int denominador)
      {
        this.numerador = numerador;
        this.denominador = denominador;
      }

    }
  }
}
