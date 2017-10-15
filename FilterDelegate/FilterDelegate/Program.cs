using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDelegate
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> listaInteiro = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      ////PREENCHI A LISTA COM NÚMERO DE 1 A 10
      //for (int i = 0; i < 10; i++)
      //{
      //  listaInteiro.Add(i);
      //}

      // Retorna apenas os números maiores que 5.
      Console.WriteLine("Números maiores que 5");
      List<int> lista1 = FilterList(listaInteiro, FilterGreatedThan5);
      ImprimirLista(lista1);

      Console.WriteLine("Números Ímpares");
      List<int> lista2 = FilterList(listaInteiro, FilterOdd);
      ImprimirLista(lista2);


      //RETORNA NÚMEROS MAIORES QUE 3 E MENORES QUE 8
      Console.WriteLine("Números maiores que 3 e menores que 8");
      List<int> lista3 = FilterList(listaInteiro, Maiores3);
      ImprimirLista(lista3);


    }                                                                   //FILTER É COMO SE ELE ESTIVESSE PASSANDO O MÉTODO COMO PARÂMETRO NO FILTER
    public static List<int> FilterList(List<int> lista, Filter filter) //FILTER É O MÉTODO A SER CHAMADO DEPENDENDO DA LISTA QUE O CHAMA QUE FOI REGISTRADO NO DELEGATE
    {

      // Cria uma nova lista.
      List<int> newList = new List<int>();

      foreach (var inteiros in lista)
      {
        if (filter(inteiros)) //AQUI ELE IRA CHAMAR O MÉTODO RESPECTIVO DA LISTA OU FilterGreatedThan5 OU FilterOdd
        {
          // Se a chamada ao delegate no elemento n retornar true, insere na lista o elemento.
          newList.Add(inteiros);
        }
      }
      return newList;
    }

    static bool FilterGreatedThan5(int n)
    {
      return n > 5;//RETORNA VERDADEIRO SE A CONDIÇÃO FOR VERDADEIRA RETORNA FALSO SE A CONDIÇÃO FOR FALSA
    }

    static bool FilterOdd(int n)
    {
      return n % 2 != 0; //RETORNA VERDADEIRO SE A CONDIÇÃO FOR VERDADEIRA RETORNA FALSO SE A CONDIÇÃO FOR FALSA
    }

    static bool Maiores3(int n)
    {
      
      return n > 3 &&  n < 8;
    }

    static void ImprimirLista(List<int> list)
    {
      foreach (var item in list)
      {
        Console.WriteLine(item);
      }
    }
  }
  public delegate bool Filter(int n);

}
