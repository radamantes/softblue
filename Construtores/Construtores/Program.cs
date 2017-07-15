using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
  class Program
  {
    static void Main(string[] args)
    {
      Salario s = new Salario(2000, 0.2,12);
      Console.WriteLine("Valor do Salário " + s.valor);
      Console.WriteLine("Mês do Salário " + s.mes);

    }
  }

  class Salario
  {
    public double valor;
    public double mes;

    public void MostrarValor()
    {
      Console.WriteLine(valor);
    }
    public Salario()
    {
      Console.WriteLine("Criando Objeto [1]");
    }


    public Salario(double valor, double bonus)
    {
      Console.WriteLine("Criando Objeto [2]");
      this.valor = valor + valor * bonus;
    }
    //CONSTRUTOR CHAMANDO O OUTRO CONSTRUTOR PRIMEIRO ELE CHAMA O PRIMEIRO CONSTRUTOR COM A PLAVRA THIS(VALOR,BONUS) E LOG TERMINAR A CHAMA DO CONSTRUTOR
    public Salario(double valor, double bonus, double mes) : this(valor, bonus)
    {
      Console.WriteLine("Criando Objeto [3]");
      this.mes = mes;
      //this.valor = valor + valor * bonus;
    }

  }

}
