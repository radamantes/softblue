using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolar
{
  class Turma
  {
    public Aluno aluno1;
    public Aluno aluno2;
    public Aluno aluno3;

    public double CalcularMedia()
    {
      double mediaTurma = (aluno1.CalcularMedia() + aluno2.CalcularMedia() + aluno3.CalcularMedia()) / 3;
      return mediaTurma;
    }

  }

}
