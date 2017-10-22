using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLGetMethodsSystemLINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      Type t = typeof(object);
      

      XElement xml = new XElement("type", new XAttribute("name", t.FullName), //PRIMEIRA TAG DO ARQUIVO XML
         from m in t.GetMethods() //DEPOIS LEIO OS METODOS
         select new XElement("method", //CRIO UMA TAG METHOD
             new XElement("name", m.Name), //AQUI COMÇEO A POPULAR COM OS DADOS t.GetMethods com os métodos
             new XElement("returnType", m.ReturnType.FullName), //SERVE PARA RETORNAR O PARÂMEOTROS DOS MÉTODOS
             new XElement("params",   //ABRO OUTRA TAG
                 from p in m.GetParameters() //LEIO OS PARÂMETRPS
                 select new XElement("param", new XAttribute("name", p.Name), p.ParameterType.FullName))));//POPULO COM OS NOMES DOS PARÂMETROS


      xml.Save("arquivo.xml"); //salvo em um arquivo xml

      Console.WriteLine(xml);

    }
  }
}
