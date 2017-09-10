using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionarios
{
  class Program
  {
    static void Main(string[] args)
    {
      Estado e1 = new Estado("Minas Gerais");
      Estado e2 = new Estado("São Paulo");
      Estado e3 = new Estado("Rio de Janeiro");

      //NÃO PODEMOS TER CHAVES DUPLICADOS 
      //CASO VOCÊ CRIE UMA CLASSE COMO CHAVE VOCÊ DEVE IMPLEMENTAR Equals e GetHashCode para saber como identifcar o que é uma chave igual e uma chave diferente
      //VOCÊ PODE TB UTILIZAR O SortedDictionary para já colocar seu dicionário ordernado de forma alfabética
      Dictionary<string, Estado> dic = new Dictionary<string, Estado>();
      dic.Add("MG", e1);
      dic.Add("SP", e2);
      dic.Add("RJ", e3);

      
      //AQUI E A PRIMEIRA FORMA PARA BUSCAR UM VALOR ESPECIFICADO PELA CHAVE
      try
      {
        Estado e = dic["SP"];
        Console.WriteLine(e.Nome);
      }
      catch (Exception)
      {
        Console.WriteLine("A chave não existe");
      }

      //AQUI É OUTRA FORMA DE BUSCA UM VALOR ESPECIFICADO PELA CHAVE
      Estado eSP;

      bool exist = dic.TryGetValue("RR", out eSP);
      Console.WriteLine(exist);


      //AQUI ESTOU INTERANDO PELA CHAVES PARA SABER QUAIS SÃO AS CHAVES QUE EXISTEM
      //Dictionary<string, Estado>.KeyCollection keys = dic.Keys;

      //foreach (string key in keys)
      //{
      //  Console.WriteLine(key);
      //}

      //-----------------------------------------------------------------------------//

      //AQUI ESTOU INTERANDO PELOS VALORES PARA SABER QUAIS SÃO AS VALORES QUE EXISTEM 
      //Dictionary<string, Estado>.ValueCollection values = dic.Values;

      //foreach (Estado value in values)
      //{
      //  Console.WriteLine(value.Nome);
      //}

      //-----------------------------------------------------------------------------//

      //AQUI IREI INTERAR PARA BUSCAR AS CHAVES E VALORES AO MESMO TEMPO
      foreach (KeyValuePair<string, Estado> item in dic)
      {
        string key = item.Key;
        Estado value = item.Value;

        Console.WriteLine(key + " => " + value.Nome);
      }

    }
  }

  public class Estado
  {
    public string Nome { get; set; }

    public Estado(string nome)
    {
      this.Nome = nome;
    }
  }
}
