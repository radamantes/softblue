using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilasPilhas
{
  class Program
  {
    static void Main(string[] args)
    {
      //CRIANDO UMA NOVA FILA - O PRIMEIRO A ENTRAR É O PRIMEIRO A SAIR
      //Queue<char> fila = new Queue<char>();

      //CRIANDO UMA NOVA PILHA - O ÚLTIMO A ENTRAR É O PRIMEIRO A SAIR
      Stack<char> pilha = new Stack<char>();

      ////------------------------ FILA ----------------------------------------
      //while (true)//ENQUANTO VOCÊ DIGITAR CARACTERE ELE VAI PEDINDO VALORES
      //{
      //  Console.Write("Elemento: ");
      //  string s = Console.ReadLine();


      //  //aqui ele verificar se você digitou um caractere em branco, caso sim, sai do loop e chama o método  fila.Enqueue(c);
      //  if (String.IsNullOrWhiteSpace(s))
      //  {
      //    break;
      //  }
      //  char c = s[0];
      //  fila.Enqueue(c); //MÉTODO PARA enfilerar
      //}

      //while (true)
      //{
      //  char c = fila.Dequeue(); //MÉTODO PARA DESENFILERAR
      //  Console.WriteLine("=> " + c);
      //  if (fila.Count == 0)
      //  {
      //    break; //CASO A FILA TERMINE OU SEJA IGUAL A 0 SAIA
      //  }

      //}

      // ---------------------------------------- PILHA ----------------------------------------

      while (true)//ENQUANTO VOCÊ DIGITAR CARACTERE ELE VAI PEDINDO VALORES
      {
        Console.Write("Elemento: ");
        string s = Console.ReadLine();


        //aqui ele verificar se você digitou um caractere em branco, caso sim, sai do loop e chama o método   pilha.Push(c);
        if (String.IsNullOrWhiteSpace(s))
        {
          break;
        }
        char c = s[0];
        pilha.Push(c); //MÉTODO PARA EMPILHAR
      }

      while (true)
      {
        char c = pilha.Pop(); //MÉTODO PARA DESEMPILHAR
        Console.WriteLine("=> " + c);
        if (pilha.Count == 0)
        {
          break; //CASO A PILHA TERMINE OU SEJA IGUAL A 0 SAIA
        }

      }

    }
  }
}
