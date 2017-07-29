using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolar
{
  class Program
  {
    static void Main(string[] args)
    {


      //ALUNO 1
      Aluno aluno1 = new Aluno();
      Prova provaAluno1Parte1 = new Prova();
      Prova provaAluno1Parte2 = new Prova();

      provaAluno1Parte1.notaParte1 = 4.0;
      provaAluno1Parte1.notaParte2 = 2.5;

      provaAluno1Parte2.notaParte1 = 1.0;
      provaAluno1Parte2.notaParte2 = 7.0;

      //ASSOCIANDO PROVA AO ALUNO
      aluno1.prova1 = provaAluno1Parte1;
      aluno1.prova2 = provaAluno1Parte2;

      double mediaAluno1 = aluno1.CalcularMedia();

      Console.WriteLine("Média aluno 1 - " + mediaAluno1);



      //ALUNO 2
      Aluno aluno2 = new Aluno();
      Prova provaAluno2Parte1 = new Prova();
      Prova provaAluno2Parte2 = new Prova();

      provaAluno2Parte1.notaParte1 = 6.5;
      provaAluno2Parte1.notaParte2 = 10;

      provaAluno2Parte2.notaParte1 = 6;
      provaAluno2Parte2.notaParte2 = 8;

      //ASSOCIANDO PROVA AO ALUNO
      aluno2.prova1 = provaAluno2Parte1;
      aluno2.prova2 = provaAluno2Parte2;

      double mediaAluno2 = aluno2.CalcularMedia();

      Console.WriteLine("Média aluno 2 - " + mediaAluno2);



      //ALUNO 3
      Aluno aluno3 = new Aluno();
      Prova provaAluno3Parte1 = new Prova();
      Prova provaAluno3Parte2 = new Prova();

      provaAluno3Parte1.notaParte1 = 6;
      provaAluno3Parte1.notaParte2 = 7;

      provaAluno3Parte2.notaParte1 = 3;
      provaAluno3Parte2.notaParte2 = 10;

      //ASSOCIANDO PROVA AO ALUNO
      aluno3.prova1 = provaAluno3Parte1;
      aluno3.prova2 = provaAluno3Parte2;

      double mediaAluno3 = aluno3.CalcularMedia();

      Console.WriteLine("Média aluno 3 - " + mediaAluno3);


      //ASSOCIANDO ALUNO A TURMA
      Turma turma = new Turma();
      turma.aluno1 = aluno1;
      turma.aluno2 = aluno2;
      turma.aluno3 = aluno3;

      double mediaTurma = turma.CalcularMedia();
      Console.WriteLine("Media Turma é : " + mediaTurma);

    }
  }
}
