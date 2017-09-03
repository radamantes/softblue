using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaFilhaColecaoArray
{
  class Program
  {
    static void Main(string[] args)
    {
      // Manipula dados em uma pilha
      Colecao c1 = new Pilha();
      ManipularDados(c1);

      // Manipula dados em uma fila
      //Colecao c2 = new Fila();
      //ManipularDados(c2);

    }
    // Insere três itens na coleção e retira os três itens da coleção.
    // Perceba a presença forte do polimorfismo: dependendo do tipo de parâmetro passado para este método,
    // o resultado final muda.
    private static void ManipularDados(Colecao c)
    {
      // Insere três itens
      c.InserirItem("A");
      c.InserirItem("B");
      c.InserirItem("C");

      Console.WriteLine();
      // Remove os três itens
      string i1 = (string)c.RemoverItem();
      string i2 = (string)c.RemoverItem();
      string i3 = (string)c.RemoverItem();

      // Imprime o resultado
      Console.WriteLine(i1 + ", " + i2 + ", " + i3);
    }
  }

  public abstract class Colecao
  {
    // Array de itens da coleção. Como são arrays de object, podem armazenar qualquer coisa
    protected object[] Itens { get; set; }

    // Construtor que recebe o tamanho da coleção como parâmetro 
    public Colecao(int tamanho)
    {
      Itens = new Object[tamanho];
    }

    // Construtor que assume o tamanho 10 por padrão
    public Colecao()
        : this(10)
    {
    }
    // Insere um item. Este método é sobrescrito pelas subclasses.
    public abstract void InserirItem(object item);

    // Remove um item. Este método é sobrescrito pelas subclasses
    public abstract object RemoverItem();
  }
  //CRIA PILHA
  public class Pilha : Colecao
  {

    // Posição do elemento que está no topo da pilha
    protected int posAtual;

    public Pilha() : base()
    {
    }

    public Pilha(int tamanho)
        : base(tamanho)
    {
    }

    // Insere um item na coleção
    public override void InserirItem(object item)
    {
      Itens[posAtual] = item;
      posAtual++;
    }

    // Remove o último elemento adicionado à coleção
    public override object RemoverItem()
    {
      posAtual--;
      Object item = Itens[posAtual];
      Itens[posAtual] = null;
      return item;
    }
  }
}
