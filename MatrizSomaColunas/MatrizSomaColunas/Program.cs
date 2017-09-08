using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSomaColunas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite o números de linhas da matriz");
      int linhas = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o números de colunas da matriz");
      int colunas = int.Parse(Console.ReadLine());

      //CRIEI UMA MATRIZ QUE RECEBE COMO PARAMETROS O NÚMERO DE LINHAS E COLUNAS QUE VAI SER DEFINIDO PELO USUÁRIO
      int[,] matriz = new int[linhas, colunas];

      //MÉTODO PARA COLOCAR DADOS NA MATRIX
      PreencherMatriz(matriz);

      //MÉTODO QUE IMPRIMIR OS DADOS DA MATRIZ CONTIDO NA MATRIX
      Imprimir(matriz);

      int[] arraySomaColuna = new int[colunas]; //CRIEI UM ARRAY COM O NÚMERO PASSADO PELO USUÁRIO DE COLUNAS


      //AQUI FAZ A SOMA DAS COLUNAS
      for (int i = 0; i < arraySomaColuna.Length; i++)
      {
        // A variável soma acumula a soma das linhas.
        int somaLinhas = 0;

        // Itera sobre as linhas da coluna.
        for (int j = 0; j < matriz.GetLength(0); j++)
        {
          // Vai somando os valores das linhas.
          somaLinhas += matriz[j, i];
        }
        // No final, armazena a soma no array de somas.
        arraySomaColuna[i] = somaLinhas;
      }

      //MÉTODO CRIADO PARA IMPRIMIR A SOMA DO ARRAY DE CADA COLUNA
      ImprimirSomaColunas(arraySomaColuna);

    }


    //MÉTODO CRIADO PARA IMPRIMIR A SOMA DO ARRAY DE CADA COLUNA
    private static void ImprimirSomaColunas(int[] arraySomaColuna)
    {
      Console.WriteLine("-----------------");
      Console.WriteLine("Somas das Colunas");
      Console.WriteLine("-----------------");

      for (int i = 0; i < arraySomaColuna.Length; i++)
      {
        Console.Write("{0,-5}", arraySomaColuna[i]);
      }
      Console.WriteLine(); //UTILIZEI PARA QUEBRA DE LINHA
    }



    //MÉTODO QUE PREENCHE OS VALORES DA MATRIZ
    private static void PreencherMatriz(int[,] matriz)
    {

      for (int l = 0; l < matriz.GetLength(0); l++)
      {
        for (int c = 0; c < matriz.GetLength(1); c++)
        {
          Console.WriteLine("Valor para o elemento [{0},{1}]: ", l, c);
          matriz[l, c] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();//UTILIZEI PARA QUEBRA DE LINHA
      }
    }
    //MÉTODO QUE IMPRIMIR OS VALORES DA MATRIZ
    private static void Imprimir(int[,] matriz)
    {
      Console.WriteLine("------------------");
      Console.WriteLine("Impressão do Array");
      Console.WriteLine("------------------");

      for (int l = 0; l < matriz.GetLength(0); l++)
      {
        for (int c = 0; c < matriz.GetLength(1); c++)
        {
          Console.Write("{0,-5}", matriz[l, c]);
        }
        Console.WriteLine();//UTILIZEI PARA DAR UMA QUEBRA DE LINHA
      }
    }
    // Vai somando os valores das linhas.
  }
}

