using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
  class Program
  {
    static void Main(string[] args)
    {

      //NÃO É PERMITIDO COLOCAR ELEMENTOS DUPLICADOS
      HashSet<string> dias = new HashSet<string>(); // AQUI VOCÊ PODE SUBSTITUIR POR SortedSet para ordernar em ordem alfabética é um conjunto Ordenado

   

      dias.Add("Segunda");
      dias.Add("Terça");
      dias.Add("Quarta");
      dias.Add("Quarta"); //SE VOCÊ PERCE ELE IRÁ SOMENTE ADICIONAR UMA Quarta
      dias.Add("Quinta");
      dias.Add("Sexta");

      foreach (var item in dias)
      {
        Console.WriteLine(item);
      }

      //HashSet<Conta> contas = new HashSet<Conta>();
      //contas.Add(new Conta(152363));
      //contas.Add(new Conta(954782));
      //contas.Add(new Conta(147852));
      //contas.Add(new Conta(222222)); 
      //contas.Add(new Conta(222222)); // FIZ UMA IMPLEMENTAÇÃO QUE NÃO PERMITI ADICIONAR 2 NÚMEROS DE CONTAS IGUAIS PARA ISTO DEVEMOS IMPLEMENTAR Equals - GetHashCode - IEquatable


      //foreach (var conta in contas)
      //{
      //  Console.WriteLine(conta.Numero);
      //}


    }
  }
  class Conta : IEquatable<Conta>
  {
    public int Numero { get; set; }

    public Conta(int numero)
    {
      this.Numero = numero;
    }


    public override bool Equals(object obj)
    {
      return Equals(obj as Conta);
    }

    public bool Equals(Conta other)
    {
      if(other == null)
      {
        return false;
      }
      return this.Numero == other.Numero; 
    }
    public override int GetHashCode()
    {
      int hash = 27;
      hash = (13 * hash) + Numero.GetHashCode();
      return hash;
    }
  }
}
