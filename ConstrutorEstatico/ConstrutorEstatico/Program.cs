using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorEstatico
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Cambio.contacaoDolar);
      Console.WriteLine(Cambio.contacaoDolar);
    }
  }

  class Cambio
  {
    //cotacao dolar varias dia apoís dia
    public static double contacaoDolar;

    //ELE SEMPRE IRÁ SER A PRIMEIRA COISA A SER CHAMADO
    //ELE SÓ É CHAMADO UMA ÚNICA X NÃO IMPORTA QUANTAS X VOCÊ TENTE.
    //CONSTRUTOR ESTÁTICO INICIALIZAR FIELDS ESTÁTICOS DA CLASSE NTILIZAR A PALAVRA PUBLIC E NÃO PODE TER PARÂMETROS
    //É CHAMADO QUANDO A CLASSE É REFERENCIADO LEMBRANDO QUE NÃO PODEMOS instanciar
    static Cambio()
    {
      Console.WriteLine("Construtor Chamado");
      contacaoDolar = 2.1;
    }

  }
}
