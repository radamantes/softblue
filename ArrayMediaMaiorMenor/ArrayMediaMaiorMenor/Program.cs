using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMediaMaiorMenor
{
  class Program
  {
    static void Main(string[] args)
    {
      double[] numeros = new double[5];

      double soma = 0;
      double media = 0;
      double menor = double.MaxValue;
      double maior = 0;

      for (int i = 0; i < numeros.Length; i++)
      {

        Console.Write("Digite o {0}º valor : ", i + 1);


        double valores = double.Parse(Console.ReadLine());
        numeros[i] = valores;

        //AQUI EU ESTOU FAZENDO A COPAPRAÇÃO PARA VER QUAL É O MAIOR VALOR
        if (valores > maior)
        {
          maior = valores;
        }
        //AQUI EU ESTOU FAZENDO A COPAPRAÇÃO PARA VER QUAL É O MENOR VALOR
        if (valores < menor)
        {
          menor = valores;
        }
        soma += valores;
      }

      ComparadorDecrescente c = new ComparadorDecrescente();
      Array.Sort(numeros, c);//O MÉTODO SHORT FOI ALTERADO PARA MOSTRA DE FORMA DECRESCENTE, POR PADRÃO ELE MOSTRA EM FORMA CRESCENTE



      Console.Write("Array ordenado : ");
      foreach (var item in numeros)
      {
        Console.Write(" " + item);
      }


      media = soma / numeros.Length; //AQUI CALCULO A MÉDIA 

      Console.WriteLine();//AQUI FIZ UMA SIMPLES QUEBRA DE LINHA
      Console.WriteLine("A média é : {0} ", media);
      Console.WriteLine("O maior valor é: {0} ", maior);
      Console.WriteLine("O menor valor é: {0} ", menor);
    }
  }

  //ESSA CLASSE FOI CRIADA PARA ORDERNAR O ARRAY DE FORMA DECRESCENTE
  public class ComparadorDecrescente : IComparer<double>
  {
    public int Compare(double x, double y)
    {
      if (x == y)
      {
        return 0;
      }
      if (x > y)
      {
        return -1;
      }
      return 1;
    }
  }

  //
  // Classe que implementa o crítério de ordenação. //ESSA OUTRA CLASSE FAZ A MESMA COISA DA DE CIMA POREM DE UMA FORMA MAIS SIMPLES
  //class ArrayComparer : IComparer<int>
  //{
  //  public int Compare(int x, int y)
  //  {
  //    // Usa o CompareTo() já existente no int. Como este método faz a ordenação em ordem crescente, a inversão do sinal 
  //    // faz com que a ordenação seja feita em ordem decrescente.
  //    return -x.CompareTo(y);
  //  }
  //}
}
