using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSimuladorMegaSena
{
  class Program
  {
    // Este algoritmo não faz validação de intervalos de números ou se os números digitados são válidos.

    static void Main(string[] args)
    {
      Console.WriteLine("Simulador Mega-Sena");
      Console.WriteLine("-------------------");

      //NÚMERO EM QUE O USUÁRIO APOSTOU
      Console.Write("Palpite 1: "); 
      int p1 = int.Parse(Console.ReadLine());
      Console.Write("Palpite 2: ");
      int p2 = int.Parse(Console.ReadLine());
      Console.Write("Palpite 3: ");
      int p3 = int.Parse(Console.ReadLine());
      Console.Write("Palpite 4: ");
      int p4 = int.Parse(Console.ReadLine());
      Console.Write("Palpite 5: ");
      int p5 = int.Parse(Console.ReadLine());
      Console.Write("Palpite 6: ");
      int p6 = int.Parse(Console.ReadLine());

      //AQUI GERA OS NÚMEROS DO SORTEIO
      Random r1 = new Random(10);
      int s1 = r1.Next(1,61);

      Random r2 = new Random();
      int s2 = r1.Next(1, 61);

      Random r3 = new Random();
      int s3 = r1.Next(1, 61);

      Random r4 = new Random();
      int s4 = r1.Next(1, 61);

      Random r5 = new Random();
      int s5 = r1.Next(1, 61);

      Random r6 = new Random();
      int s6 = r1.Next(1, 61);

      //VÁRIAVEL PARA DEFINIR QUANTOS NÚMERO O USUÁRIO ACERTOU NO FINAL
      int acertos=0;

      if (s1 == p1 || s1 == p2 || s1 == p3 || s1 == p4 || s1 == p5 || s1 == p6)
      {
        acertos++;
      }
      if (s2 == p1 || s1 == p2 || s1 == p3 || s1 == p4 || s1 == p5 || s1 == p6)
      {
        acertos++;
      }
      if (s3 == p1 || s1 == p2 || s1 == p3 || s1 == p4 || s1 == p5 || s1 == p6)
      {
        acertos++;
      }
      if (s4 == p1 || s1 == p2 || s1 == p3 || s1 == p4 || s1 == p5 || s1 == p6)
      {
        acertos++;
      }
      if (s5 == p1 || s1 == p2 || s1 == p3 || s1 == p4 || s1 == p5 || s1 == p6)
      {
        acertos++;
      }
      if (s6 == p1 || s1 == p2 || s1 == p3 || s1 == p4 || s1 == p5 || s1 == p6)
      {
        acertos++;
      }
      Console.WriteLine("Os números sorteados foram: {0}-{1}-{2}-{3}-{4}-{5}", s1, s2,s3,s4,s5,s6);
      Console.WriteLine("Você acertou {0} números ", acertos);

    }
  }
}
