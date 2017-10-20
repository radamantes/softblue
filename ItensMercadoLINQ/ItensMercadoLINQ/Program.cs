using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItensMercadoLINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      var lista = CriarLista();

      //Retorne uma lista de itens do tipo Higiene ordenados por ordem decrescente de preço.
      //var itensHigiente = from i in lista
      //                    where i.Tipo == Tipo.Higiene
      //                    orderby i.Preco descending
      //                    select i;


      //Retorne uma lista de itens cujo preço seja maior ou igual a R$ 5,00.A ordenação deve ser feita por ordem crescente de preço.
      //var itensHigiente = from i in lista
      //                    where i.Preco >= 5
      //                    orderby i.Preco descending
      //                    select i;


      //Retorne uma lista de itens cujo tipo seja Comida ou Bebida.A ordenação deve ser feita por nome em ordem alfabética.
      //var itensHigiente = from i in lista
      //                    where i.Tipo == Tipo.Comida || i.Tipo == Tipo.Bebida
      //                    orderby i.Nome //ordenando em ordem alfabética pelo nome
      //                    select i;

      //RETORNO OS VALORES QUE ESTÃO PRESENTE SÃO ITENS DE HIGIENE E QUE TEM O PREÇO MAIOR OU IGUAL A 5
      //var itensHigiente = from i in lista
      //                    where i.Preco >= 5 && i.Tipo == Tipo.Higiene
      //                    select i;

      //Retorne cada um dos tipos associado com a quantidade de itens de cada tipo. 
      //var itensHigiente = from i in lista
      //                    group i by i.Tipo into g // SELECIONAR PARA AGRUPAR POR TIPO OU SEJA QUERO SABER QUANTOS TEM DO TIPO.COMIDA QUANTO TEM DO TIPO.BEBIDAS ETC..
      //                    select new { Tipo = g.Key, Quantidade = g.Count() }; //g.key = chave ou seja = "Bebida" "Higiente"



      //Retorne cada um dos tipos associado com o preço máximo, preço mínimo e média de preço de cada tipo. 
      var itensHigiente = from i in lista
                          group i by i.Tipo into g
                          select new { Tipo = g.Key, Min = g.Min(i => i.Preco), Max = g.Max(i => i.Preco), Media = g.Average(i => i.Preco) }; // A LETRA DENTRO DA EXPRESSÃO LAMBDA NÃO IMPORTA


      //Retorne cada um dos tipos associado com o preço máximo, preço mínimo e média de preço de cada tipo. 
      //var itensHigiente = from i in lista
      //                    where i.Tipo == Tipo.Comida
      //                    select i.Preco;


      //Console.WriteLine("Mínimo Comida " + itensHigiente.Min());
      //Console.WriteLine("Máximo Comida " + itensHigiente.Max());
      //Console.WriteLine("Média Comida " + itensHigiente.Average());


      foreach (var item in itensHigiente)
      {
        Console.WriteLine(item.ToString());
      }
    }

    public static List<ItemMercado> CriarLista()
    {
      List<ItemMercado> itens = new List<ItemMercado>();

      {
        itens.Add(new ItemMercado { Nome = "Arroz", Tipo = Tipo.Comida, Preco = 3.90 });
        itens.Add(new ItemMercado { Nome = "Azeite", Tipo = Tipo.Comida, Preco = 2.50 });
        itens.Add(new ItemMercado { Nome = "Macarrão", Tipo = Tipo.Comida, Preco = 3.90 });
        itens.Add(new ItemMercado { Nome = "Cerveja", Tipo = Tipo.Bebida, Preco = 22.90 });
        itens.Add(new ItemMercado { Nome = "Refrigerante", Tipo = Tipo.Bebida, Preco = 5.70 });
        itens.Add(new ItemMercado { Nome = "Shampoo", Tipo = Tipo.Higiene, Preco = 7.00 });
        itens.Add(new ItemMercado { Nome = "Cotonete", Tipo = Tipo.Higiene, Preco = 5.70 });
        itens.Add(new ItemMercado { Nome = "Sabonete", Tipo = Tipo.Higiene, Preco = 5.70 });
        itens.Add(new ItemMercado { Nome = "Sabão em Pó", Tipo = Tipo.Limpeza, Preco = 8.20 });
        itens.Add(new ItemMercado { Nome = "Amaciante", Tipo = Tipo.Limpeza, Preco = 6.40 });
        itens.Add(new ItemMercado { Nome = "Detergente", Tipo = Tipo.Limpeza, Preco = 2.60 });
      }

      return itens;
    }
  }
  class ItemMercado
  {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public Tipo Tipo { get; set; }

    public override string ToString()
    {
      return Nome + " - " + Preco + " - " + Tipo;
    }
  }

  public enum Tipo
  {
    Comida,
    Bebida,
    Higiene,
    Limpeza
  }


}
