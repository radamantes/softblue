using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPredicateCount
{
  class Program
  {
    static void Main(string[] args)
    {
      //CRIANDO LISTA 
      List<int> list = new List<int>();

      //CRIACAO DE UM OBJETO RANDOM PARA CRIAR UMA LISTA DE FORMA RÁPIDO CON INTEIROS RANDÔMICOS
      Random r = new Random();

      //CRIANDO DO PREDICATE
      Predicate<int> p = x => x > 5; //EXPRESSÃO LAMBDA P É A VARIÁVEL QUE ARMAZENA A EXPRESSÃO LAMBDA  X=> X>= 5 É A EXPRESSÃO LAMBDA QUE RETORNA NÚMEROS MAIORES QUE 5

      //PREECHENDO A LISTA
      for (int i = 0; i < 25; i++) //COLOQUEI O 25 PQ SOMENTE QUERO ATÉ QUE SEJA PREENCHIDA COM 25 ITENS
      {
        //ADICIONANDO NÚMEROS RANDÔMICOS NA LISTA ENTRE 1 A 30        
        int n = r.Next(30);
        list.Add(n);
      }
    
      //AQUI CHAMO O MÉTODO PASSANDO A LISTA QUE FOI GERADA COMO PARÂMETRO MAIS O Predicate que foi minha expressão Lambda criadao acima
      Count(list, p);
    }

    public static void Count(List<int> lista, Predicate<int> p)
    {

      List<int> newList = lista.FindAll(p);

      foreach (var item in newList)
      {
        Console.WriteLine(item);
      }

    }
  }
}
