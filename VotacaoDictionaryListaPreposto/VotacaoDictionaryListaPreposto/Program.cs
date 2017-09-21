using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotacaoDictionaryListaPreposto
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<int, string> linguagens = new Dictionary<int, string>();
      linguagens.Add(1, "C#");
      linguagens.Add(2, "Java");
      linguagens.Add(3, "C");
      linguagens.Add(4, "C++");
      linguagens.Add(5, "Python");
      linguagens.Add(6, "PHP");

      List<int> votos = new List<int>();

      int opcao = -1; //VARIÁVEL SOMENTE PARA FAZER A VERIFICAÇÃO QUANDO ELE DIGITA 0 TERMINA A APLICAÇÃO
      int numeroVotos = 0;
      double nTotalVotos = 0; //VARIÁVEL PARA LER QUANTO VOTOS TEVE AO TODO
      int maiorValor = 0; //VARIÁVEL PARA ARMAZENAR O VALOR DA LINGAGEM MAIS VOTADA
      string nomeLinguagemMaisVotada = null; //VARIÁVEL PARA ARMAZENAR O NOME A LINGAGEM MAIS VOTADA

      while (opcao != 0) //ENQUANTO FOR DIFERENTE DE 0 ELE CONTINUA EXECUTANDO A APLICAÇÃO
      {
        // Lê a opção votada. //chama o método
        opcao = Votar(linguagens, votos);
        Console.WriteLine("Obrigado pelo seu voto!\n");
      }
      //CASO O VALOR DIGITADO NA OPÇÃO SEJA 0 ELE IRÁ MOSTRAR O RESULTADO DA VOTAÇÃO
      Console.WriteLine("{0,-25}{1,8}{2,10}", "Linguagem de Programação", "Votos", "%");
      Console.WriteLine("{0,-25}{1,8}{2,10}", "------------------------", "-----", "-");

      foreach (var item in linguagens)
      {
        int nKey = item.Key;
        string nValor = item.Value;
        numeroVotos = ContarVotos(nKey, votos);//AQUI PRIMEIRO ELE VERIFICA O NÚMERO TOTAL DE VOTO DE CADA OPÇÃO POR EXEMPLO C# - E VAI PARA LINHA DE BAIXO, DEPOIS ELE VOLTAR A TESTAR ESSA LINHA PORÉM COM OUTRA OPÇÃO EXEMPLO JAVA

        nTotalVotos = votos.Count() - 1; //COLOQUEI MENOS UM PQ QDO ELE DIGITA 0 PARA SAIR DA APLICAÇÃO ESTÁ SENDO CONTADO COMO VOTO TAMBÉM ENTÃO PARA RESOLVER ISSO DIMINUI UM NÚMERO
        double calculaPorcentagem = numeroVotos * 100 / nTotalVotos;

        if (numeroVotos > maiorValor)
        {
          maiorValor = numeroVotos;
          nomeLinguagemMaisVotada = nValor;
        }

        Console.WriteLine("{0,-25}{1,8}{2,10:P}", nValor, numeroVotos, calculaPorcentagem / 100);
      }
      Console.WriteLine("A Linguagem mais votado foi {0} com {1} votos", nomeLinguagemMaisVotada, maiorValor);
      Console.WriteLine("Número total de votos {0}", nTotalVotos);
    }

    //MÉTODO ESTÁTICO QUE LISTA A OPÇÕES PARA QUE O USUÁRIO POSSA VOTAR
    public static int Votar(Dictionary<int, string> opcoes, List<int> votos)
    {
      int opcao;

      Console.WriteLine("Qual é sua linguagem de programação favorita");

      // IMPRIMI A LISTA QUE ESTÁ ARMAZENADO NO DICIONÁRIO DAS OPÇÕES
      foreach (var item in opcoes)
      {
        int nKey = item.Key;
        string nValor = item.Value;
        Console.WriteLine("{0} - {1}", nKey, nValor);
      }
      Console.Write("Escolha uma opção ou 0 para sair do aplicativo : ");
      opcao = int.Parse(Console.ReadLine());//AQUI ELE CONVERTE CADA VOTO EM UM INT

      votos.Add(opcao);//AQUI ELE ARMAZENA OS VOTOS NA LISTA DE INT

      return opcao;//AQUI ELE RETORNA A OPÇÃO DIGITADA PARA FAZER A VALIDAÇÃO NOVAMENTE, PARA VER SE FOI DIGITADO 0 E ENCERRAR O APLICATIVO OU PARA CONTINUAR A EXECUÇÃO
    }



    //ESSE MÉTODO IRÁ RETORNA UM NÚMERO TOTAL DE VOTOS PARA CADA OPÇÃO
    public static int ContarVotos(int n, List<int> votos)
    {
      int numVotos = 0;

      foreach (var item in votos)
      {
        if (item == n) //AQUI ELE VERIFICA SE O VOTO É IGUAL O DA CHAVE PASSADO POR EXEMPLO C# = 1, ENTÃO ELE PERCORRE A LISTA DE VOTOS E VERIFICA QUANTAS TEM IGUAL AO NÚMERO 1
        {
          numVotos++;
        }
      }
      return numVotos;
    }
  }

}

