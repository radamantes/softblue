using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Matematica.PI);//CONS AUTOMATICAMENTE SÃO DE FORMÁ IMPLÍCA STÁTIC POR ISSO ACESSEI ELE SEM INSTANCIAR
    }
  }
  class Matematica
  {

    
    public static int x = 2;
    //CONS AUTOMATICAMENTE SÃO DE FORMÁ IMPLÍCA STÁTIC POR ISSO ACESSEI ELE SEM INSTANCIAR
    //public const double PI = 5 * x; //ASSIM NÃO É PERMITIDO


    //readonly não são estáticos por padrão como as constantes
    //A PARTIR DE UM MOMENTO QUE VC DEFINIU UM VALOR PARA READONLY NÃO PODERÁ SER MAIS ALTERADO
    public static readonly double PI = 5 * x; //ASSIM É PERMITIDO
  }
}
