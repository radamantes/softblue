using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolar
{
  class Prova
  {
    public double notaParte1;
    public double notaParte2;

    public double CalcularNotaTotal()
    {
      return notaParte1 + notaParte2;
    }

  }
}
