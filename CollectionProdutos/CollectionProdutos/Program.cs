using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProdutos
{
  class Program
  {
    static void Main(string[] args)
    {
      //CRIANDO PRODUTOS
      Produto p1 = new Produto("Abrigo", 120.12);
      Produto p2 = new Produto("Chompa", 70.25);
      Produto p3 = new Produto("Ropa Interior", 7.50);
      Produto p4 = new Produto("Sandalias", 10.15);
      Produto p5 = new Produto("Sandalias", 35.5);
      Produto p6 = new Produto("Cepillo", 5.70);

      //-----------------------List--------------------------------------

      //ADICIONANDO PRODUTOS A MINHA LISTA UTILIZANDO LIST
      Produtos listaProdutos = new Produtos(new List<Produto>());
      listaProdutos.Adicionar(p1);
      listaProdutos.Adicionar(p2);
      listaProdutos.Adicionar(p3);
      listaProdutos.Adicionar(p4);
      listaProdutos.Adicionar(p5);
      listaProdutos.Adicionar(p6);
      
      //MÉTODO PARA IMPRIMIR LISTA DE PRODUTOS DA List
      listaProdutos.ImprimirProdutos();

      //-----------------------SortedSet--------------------------------------

      Produtos listaProdutosSorted = new Produtos(new SortedSet<Produto>());
      //ADICIONANDO PRODUTOS A MINHA LISTA UTILIZANDO SortedSet
      listaProdutosSorted.Adicionar(p1);
      listaProdutosSorted.Adicionar(p2);
      listaProdutosSorted.Adicionar(p3);
      listaProdutosSorted.Adicionar(p4);
      listaProdutosSorted.Adicionar(p5);
      listaProdutosSorted.Adicionar(p6);

      //MÉTODO PARA IMPRIMIR LISTA DE PRODUTOS DA SortedSet
      listaProdutosSorted.ImprimirProdutos();

      //-----------------------HashSet--------------------------------------

      Produtos listaProdutosHashSet = new Produtos(new HashSet<Produto>()); //LEMBRANDO QUE O HashSet não aceita produtos duplicados
      //ADICIONANDO PRODUTOS A MINHA LISTA UTILIZANDO HashSe
      listaProdutosHashSet.Adicionar(p1);
      listaProdutosHashSet.Adicionar(p2);
      listaProdutosHashSet.Adicionar(p3);
      listaProdutosHashSet.Adicionar(p4);
      listaProdutosHashSet.Adicionar(p5);
      listaProdutosHashSet.Adicionar(p6);
      //IMPRIMINDO HashSet
      listaProdutosHashSet.ImprimirProdutos();




    }
  }
  public class Produto : IComparable<Produto>, IEquatable<Produto>
  {
    public string Nome { get; set; }
    public double Valor { get; set; }

    public Produto(string nome, double valor)
    {
      this.Nome = nome;
      this.Valor = valor;
    }

    public int CompareTo(Produto other)
    {
      return this.Valor.CompareTo(other.Valor); //ORDENANDO O SortedSet Por Valor
    }

    /* * Elementos que são inseridos em um Set normalmente devem implementar os métodos Equals() e 
       * GetHashCode(). Eles definem o que são elementos iguais e diferentes.
       * Neste caso, dois produtos iguais são os que tem o mesmo nome.
     */
    public override int GetHashCode() 
    {
      return Nome.GetHashCode();
    }
    public override bool Equals(Object obj)
    {
      return Equals(obj as Produto);
    }

    public bool Equals(Produto other)
    {
      return this.Nome == other.Nome;
    }
    //MÉTODO PARA SOBRESCREVER O TOSTRING
    public override string ToString()
    {
      return String.Format("Produto : {0} | Valor: {1} ", Nome, Valor);
    }
  }

  public class Produtos
  {
    ICollection<Produto> produtos;// COLOQUEI ICOLLECTION PARA QUE POSSA UTILIZAR QUALQUER TIPO DE COLEÇÃO


    public Produtos(ICollection<Produto> produtos)
    {
      this.produtos = produtos;
    }

    //MÉTODO PARA IMPRIMIR LISTA DE PRODUTOS
    public void ImprimirProdutos()
    {
      Console.WriteLine("Produtos armazenados em: " + produtos.GetType().Name);
      foreach (Produto item in produtos)
      {   
        Console.WriteLine(item);
      }
    }

    public void Adicionar(Produto produto)
    {
      //produtos = produto;   
      produtos.Add(produto); //ADICIONANDO PRODUTOS
    }
  }
}
