using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GravarLerBin
{
  class Program
  {
    // Constante para o arquivo que vai armazenar os dados, lembrando que uma constante não pode ser alterada
    const string File = "livros.bin";


    static void Main(string[] args)
    {
      Console.WriteLine("1 - Gravar Dados");
      Console.WriteLine("2 - Ler Dados");

      int opcao = int.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1:
          Console.WriteLine("Gravando Dados");
          GravarDados();
          break;
        case 2:
          Console.WriteLine("Lendo dados");
          LerDados();
          break;
        default:
          Console.WriteLine("Valor inválido");
          break;
      }
    }
    public static void GravarDados()
    {

      //CRIA O ARQUIVO .BIN NO MESMO DIRETÓRIO DE ONDE O ARQUIVO É COMPILADO
      FileStream fs = new FileStream(File, FileMode.Create);
      fs.Close();


      //CRIANDO O LIVRO
      Livro livro = new Livro();
      livro.Titulo = "O Programador";
      livro.NumPaginas = 500;

      //CRIANDO O AUTOR
      Autor autor = new Autor();
      autor.Date = new DateTime(2015, 10, 11);
      autor.Name = "Diego Lobato";

      //CRIANDO O LIVRO 2
      Livro livro2 = new Livro();
      livro2.Titulo = "Poderoso Chefão";
      livro2.NumPaginas = 320;

      //CRIANDO O AUTOR 2
      Autor autor2 = new Autor();
      autor2.Date = new DateTime(2012, 05,06);
      autor2.Name = "Alpachino";



      //CRIAR O BINARWRITER ABRIND O ARQUIVO PARA ESCRITA(GRAVAÇÃO)
      BinaryWriter bw = new BinaryWriter(new FileStream(File, FileMode.Open, FileAccess.Write));

      livro.Write(bw); //GRAVA O DADO DO LIVRO 1
      autor.Write(bw); //GRAVA O DADO DO AUTOR 1


      //GRAVANDO OS DADOS NO BINARY WRITER DO LIVRO E DO AUTOR 2
      livro2.Write(bw);
      autor2.Write(bw);

      bw.Close(); 
    }
    public static void LerDados()
    {

      //AQUI EU CRIO OS OBJETOS NOVAMENTE SOMENTE PARA PODER CHAMAR OS MÉTODOS OU SEJA NÃO VAI INFLUENCIAR NO RESULTADO, POIS O RESULTADO IRÁ VIM DO ARQUIVO.BIN E NÃO DA REFERÊNCIA DESSE OBJETO NOVOS

      Livro livro1 = new Livro();
      Autor autor1 = new Autor();

      Livro livro2 = new Livro();
      Autor autor2 = new Autor();


      FileStream fs = new FileStream(File, FileMode.Open, FileAccess.Read); //FILE É CRIADO NO MESMO DIRETÓRIO DE ONDE O ARQUIVO É COMPILADO

      using (BinaryReader reader = new BinaryReader(fs))
      {
        livro1.Read(reader);
        autor1.Read(reader);
        livro2.Read(reader);
        autor2.Read(reader);
      }

      Console.Write(livro1); //LER O LIVRO - FOI SOBRESCRITO UTILIZANDO O TOSTRING
      Console.WriteLine(autor1); //LER O AUTOR - FOI SOBRESCRITO UTILIZANDO O TOSTRING

      //BINÁRIO FAZ A LEITURA POR BYTES POR ISSO TIVE QUE CRIAR OS OBJETOS PARA LER EM ORDEM

      Console.Write(livro2);
      Console.WriteLine(autor2);

     
    }
  }
}