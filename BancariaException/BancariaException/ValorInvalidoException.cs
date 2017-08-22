using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancariaException
{

  public class ValorInvalidoException : Exception
  {
    private double valorInvalido;


    //CONSTRUTORES
    public ValorInvalidoException() { }
    public ValorInvalidoException(string message, double valor) : base(message)
    {
      this.valorInvalido = valor;
    }
    public ValorInvalidoException(string message, Exception inner) : base(message, inner) { }


    //PROPRIEDADE LEITURA
    public double ValorInvalido
    {
      get { return valorInvalido; }
    }
  }
}
