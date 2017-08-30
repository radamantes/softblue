using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatacaoDadosConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      //UTILIZEI OBJECT INITIALIZER, MAS TAMBÉM PODERIA UTILIZAR CONSTRUTOR

      //PRODUTO 1 CRIADO
      Produtos p1 = new Produtos() { Nome = "Feijão", Peso = 2.5, DataValidade = new DateTime(2020, 10, 04) };
      Console.WriteLine("{0}) {1,12} {2:000000.00 }{3}",1, p1.Nome, p1.Peso, p1.DataValidade.ToShortDateString());

      //PRODUTO 2 CRIADO
      Produtos p2 = new Produtos() { Nome = "Café", Peso = 1.0, DataValidade = new DateTime(2022, 01, 01) };
      Console.WriteLine("{0}) {1,12} {2:000000.00 }{3}",2, p2.Nome, p2.Peso, p2.DataValidade.ToShortDateString());

      //PRODUTO 3 CRIADO
      Produtos p3 = new Produtos() { Nome = "Beterraba", Peso = 0.90, DataValidade = new DateTime(2017, 11, 12) };
      Console.WriteLine("{0}) {1,12} {2:000000.00 }{3}",3, p3.Nome, p3.Peso, p3.DataValidade.ToShortDateString());
    }
  }
  public class Produtos
  {
    string nome;
    double peso;
    DateTime dataValidade;
            

    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }
    public double Peso
    {
      get { return peso; }
      set { peso = value; }
    }
    public DateTime DataValidade
    {
      get { return dataValidade; }
      set { dataValidade = value; }
    }
  }
  //ESSE É UM MÉTODO DE FORMATAR A DATA SEM AS HORAS


  //this.dataValidade = DateTime.Parse(dia + "/" + mes + "/" + ano);

  //public string FormattedDataValidade
  //{
  //  get
  //  {
  //    return dataValidade.ToString("d");
  //  }
  //}

}
