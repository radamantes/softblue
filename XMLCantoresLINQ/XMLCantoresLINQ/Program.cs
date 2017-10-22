using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLCantoresLINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      //CRIAÇÃO DO XML
      XElement xml = new XElement("Cantores",
            new XElement("Cantor",
               new XElement("Nome", "Elvis Presley"),
               new XElement("DataNascimento", new DateTime(1935, 08, 01).ToShortDateString())),

            new XElement("Cantor",
               new XElement("Nome", "John Lennon"),
               new XElement("DataNascimento", new DateTime(1940, 10, 09).ToShortDateString())),

            new XElement("Cantor",
                new XElement("Nome", "Stevie Wonder"),
                new XElement("DataNascimento", new DateTime(1950, 05, 13).ToShortDateString())),

            new XElement("Cantor",
                new XElement("Nome", "James Brown"),
                new XElement("DataNascimento", new DateTime(1933, 05, 03).ToShortDateString())),


            new XElement("Cantor",
                new XElement("Nome", "Bob Dylan"),
                new XElement("DataNascimento", new DateTime(1933, 05, 03).ToShortDateString())

            ));

      xml.Save("cantores.xml"); //SALVEI O ARQUIVO XML NO DISCO


      //Console.WriteLine(xml);

      XElement x = XElement.Load("cantores.xml"); //ABRO O ARQUIVO XML NO DISCO COMO ESTÁ INCORPORADO NO PROJETO NÃO NECESSITO DEFINIR O CAMINHO COMPLETO


      //1) Lista de todos os nomes dos cantores, ordenados alfabeticamente. 
      //var q = from c in x.Elements("Cantor")
      //        let nome = c.Element("Nome").Value //CRIEI UMA VARIÁVEL PARA PODER UTILIZAR EM VÁRIOS LUGARES ISSO NÃO É NECESSÁRIO
      //        orderby nome ascending
      //        select nome;


      var q = from c in x.Elements("Cantor") //BUSCA TODAS AS TAG <Cantor> //ESSA PRIMEIRA LINHA ELE SÓ EXECUTA SOMENTE UMA X

              //DEPOIS FICA INTERAGINDO SOBRE ESSA LINHAS ATÉ O FINAL DA EXPRESSÃO ++
              let nome = c.Element("Nome").Value //BUSCA A TAG <Nome> E SEU VALORno xml 
              let date = DateTime.Parse(c.Element("DataNascimento").Value)
              where date.Month == 5 
              orderby nome
              select new { Nome = nome, Date = date.ToShortDateString() };





      foreach (var item in q)
      {
        Console.WriteLine("Nome= {0} - Data= {1}",item.Nome, item.Date);
      }


      // Console.WriteLine(x);



    }
  }
}
