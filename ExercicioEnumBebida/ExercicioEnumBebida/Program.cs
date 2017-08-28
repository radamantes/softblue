using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumBebida
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("1 - Refrigerante");
      Console.WriteLine("2 - Suco");
      Console.WriteLine("3 - Água");

      int opcao = 0;

      try
      {
        opcao = int.Parse(Console.ReadLine());
      }
      catch (FormatException e)
      {
        Console.WriteLine("Não foi possível fazer a conversão, opção inválida");
        return; //PARA ENCERRAR A APLICAÇÃO CASO EXECUTA A EXCEÇÃO
      }

      // Verifica se o número digitado faz parte do enum.
      bool exist = Enum.IsDefined(typeof(Bebida), opcao);

      if (exist)
      {
        // Faz o casting para Bebida, para obter o enum e mostra a opção escolhida.
        Bebida bebida = (Bebida)opcao;
        Console.WriteLine("A bebida que você escolheu foi " + bebida);
      }

      {
        // Se o valor não existe no enum, mostra o erro.
        Console.WriteLine("A bebida escolhida não existe");
      }
    }
  }
  public enum Bebida
  {
    Refrigerante = 1,
    Suco = 2,
    Água = 3
  }
}

