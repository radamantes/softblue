using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreGenealogicaLINQ
{
  class Program
  {
    static void Main(string[] args)
    {

      List<Pessoa> lista = CriarArvoreGenealogica();

      
      var itens = from p in lista
                  select new
                  {
                    Neto = p.Nome,
                    AvôPaterno = p.Pai != null && p.Pai.Pai != null ? p.Pai.Pai.Nome : "-",
                    AvôMaterno = p.Mae != null && p.Mae.Pai != null ? p.Mae.Pai.Nome : "-",
                    AvóPaterna = p.Pai != null && p.Pai.Mae != null ? p.Pai.Mae.Nome : "-",
                    AvóMaterna = p.Mae != null && p.Mae.Mae != null ? p.Mae.Mae.Nome : "-"
                  };
      
      foreach (var i in itens)
      {
        Console.WriteLine(i.ToString());
      }
     

    }
    static List<Pessoa> CriarArvoreGenealogica()
    {
      List<Pessoa> pessoas = new List<Pessoa>();

      Pessoa angelo = new Pessoa() { Nome = "Ângelo" };
      Pessoa mariana = new Pessoa() { Nome = "Mariana" };
      Pessoa luis = new Pessoa() { Nome = "Luis" };
      Pessoa rafaela = new Pessoa() { Nome = "Rafaela" };


      Pessoa andre = new Pessoa() { Nome = "André", Pai = angelo, Mae = mariana };
      Pessoa luciana = new Pessoa() { Nome = "Luciana", Pai = luis, Mae = rafaela };


      Pessoa daniel = new Pessoa() { Nome = "Daniel", Pai = andre, Mae = luciana };

      pessoas.Add(angelo);
      pessoas.Add(mariana);
      pessoas.Add(luis);
      pessoas.Add(rafaela);
      pessoas.Add(andre);
      pessoas.Add(luciana);
      pessoas.Add(daniel);

      return pessoas;
    }
  }


 

  class Pessoa
  {
    public string Nome { get; set; }
    public Pessoa Pai { get; set; }
    public Pessoa Mae { get; set; }


    public override string ToString()
    {
      return string.Format("{0,-10}{1,-10}{2,-10}", Nome, Pai != null ? Pai.Nome : "-", Mae != null ? Mae.Nome : "-");
    }
  }
  
}