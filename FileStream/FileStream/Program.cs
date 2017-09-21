using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreams
{
  class Program
  {
    static void Main(string[] args)
    {
      //FileStream fs = new FileStream(@"C:\Curso\arquivo.txt", FileMode.Create, FileAccess.Write);

      FileInfo fi = new FileInfo(@"C:\Curso\arquivo.txt");
      //FileStream fs2 = fi.Create();
      //FileStream fs = fi.OpenWrite();

      //FileStream fs = fi.Open(FileMode.Append, FileAccess.Write);

      //1ª FORMA DE FAZER A MESMA COISA
      //try
      //{

      //  fs.WriteByte((byte)'a');
      //  fs.WriteByte((byte)'b');
      //  fs.WriteByte((byte)'c');
      //}
      //finally
      //{
      //  fs.Close();//FAZ A MESMA COISA QUE O DISPOSE
      //             // fs.Dispose();//FAZ A MESMA COISA QUE O CLOSE
      //}


      //2ª FORMA DE FAZER
      //AO FINAL DO BLOCK USING SERÁ FECHADO, NO FINAL SERÁ EXECUTA O MÉTODOD DISPOSE QUE FECHAR O ARQUIVO
      //SE OCORRER ALGUMA EXCEÇÃO ELE IRÁ FECHAR O ARQUIVO E DEPOIS IRÁ LANÇAR A EXCEÇÃO
      //using (FileStream fs = fi.Open(FileMode.Append, FileAccess.Write))
      //{
      //  fs.WriteByte((byte)'a');
      //  fs.WriteByte((byte)'b');
      //  fs.WriteByte((byte)'c');
      //}

      //ABRINDO O ARQUIVO PARA LEITURA
      //using (FileStream fs = fi.Open(FileMode.Open, FileAccess.Read))
      //{
      //  //ELE SEMPRE POSICIONAR O PONTEIRO PARA A PRÓXIMA LEITURA, PULA PARA A PROXIMA POSIÇÃO CADA X QUE EXECUTAMOS O (char)fs.ReadByte();
      //  char c = (char)fs.ReadByte();
      //  Console.WriteLine(c);

      //  c = (char)fs.ReadByte();
      //  Console.WriteLine(c);

      //  c = (char)fs.ReadByte();
      //  Console.WriteLine(c);
      //}


      ////leitura de todos os bytes
      //using (FileStream fs = fi.Open(FileMode.Open, FileAccess.Read))
      //{

      //  //AQUI ELE LÊ TODOS OS BYTES DO ARQUIVO
      //  while (fs.Position < fs.Length)
      //  {
      //    char c = (char)fs.ReadByte();
      //    Console.WriteLine(c);
      //  }
      //}

      FileInfo fiSource = new FileInfo(@"C:\Curso\logo.pdf");
      FileInfo fiTarget = new FileInfo(@"C:\Curso\logo2.pdf");

      //FAZER LEITURA DE UM E FAZER A ESCRITA EM OUTRA
      using (FileStream fsSource = fiSource.OpenRead(), fsTarget = fiTarget.OpenWrite())
      {
        Byte[] buffer = new byte[1024];

        while (true)
        {
          int byteRead = fsSource.Read(buffer, 0, buffer.Length); //LÊ OS ARQUIVO E ARMAZENA DENTRO DE UM ARRAY DE BYTE NO MEU CASO BUFFER
          if (byteRead == 0) //SIGNIFICA QUE TERMINOU DE LER OS BYTES
          {
            break;
          }
          fsTarget.Write(buffer, 0, byteRead); //AQUI ESTOU ESCREVENO NO ARQUIVO A QUANTIDADE TOTAL QUE ELE CONSEGUIU LER NO  byread}
        }

      }
    }
  }
  }
