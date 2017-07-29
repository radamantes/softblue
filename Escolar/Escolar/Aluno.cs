using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolar
{
  class Aluno
  {
    public Prova prova1;
    public Prova prova2;

    public double CalcularMedia()
    {
      return (prova1.notaParte1 + prova1.notaParte2 + prova2.notaParte1 + prova2.notaParte2)/2;
    }
  }
}
