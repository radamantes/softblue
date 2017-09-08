using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedList<string> meses = new LinkedList<string>();
      meses.AddLast("Enero");
      meses.AddLast("Febrero");
      meses.AddLast("Marzo");
      meses.AddLast("Abril");

      //foreach (var item in meses)
      //{
      //  Console.WriteLine(item);
      //}

      LinkedListNode<string> node = meses.First; //RETORNAR O PRIMEIRO NO DA LISTA TEM QUE ARMAZENAR EM UMA VARIÁVEL DO TIPO LINKEDLISTNODE
      Console.WriteLine(node.Value);
      
      
      while (node.Next !=null)
      {
        node = node.Next;
        Console.WriteLine(node.Value);
      }


      //List<string> nomes = new List<string>();
      //nomes.Add("João");
      //nomes.Add("Rafael");
      //nomes.Add("Raquel");
      //nomes.Add("Camila");
      //nomes.Add("Fernando");
      //nomes.Insert(2, "Justin");

      //bool b = nomes.Contains("Rafael");

      //Console.WriteLine(b);

      //foreach (var item in nomes)
      //{
      //  Console.WriteLine(item);
      //}

      //Console.WriteLine("Utilizando FOR");
      //for (int i = 0; i < nomes.Count; i++)
      //{
      //  Console.WriteLine(nomes[i]);
      //}

      //int pos = nomes.IndexOf("Camila");
      //Console.WriteLine(pos);
    }
  }
}
