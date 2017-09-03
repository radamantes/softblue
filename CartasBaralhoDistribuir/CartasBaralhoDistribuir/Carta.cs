using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasBaralhoDistribuir
{

  public class Carta
  {
    public enum Naipe
    {
      Copas,
      Ouros,
      Paus,
      Espadas
    }

    public int valor { get; private set; }
    public Naipe naipe { get; private set; }

    public Carta(int valor, Naipe naipe)
    {
      this.valor = valor;
      this.naipe = naipe;
    }

    public override string ToString()
    {
      return string.Format("{0} de {1}", valor, naipe);
    }
  }
}
