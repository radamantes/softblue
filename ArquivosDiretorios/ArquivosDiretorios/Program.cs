using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivosDiretorios
{
  class Program
  {
    static void Main(string[] args)
    {
      //FileInfo file1 = new FileInfo(@"C:\Curso\arq1.txt");
      //file1.Create();

      //File.Create(@"C:\Curso\arq2.txt");

      //file1.CopyTo(@"C:\Curso\copy1.txt");
      //File.Copy(@"C:\Curso\arq1.txt", @"C:\Curso\copy2.txt");

      //Console.WriteLine("Nome " + file1.Name);
      //Console.WriteLine("Extesão " + file1.Extension);
      //Console.WriteLine("Existe " + file1.Exists);
      //Console.WriteLine("Diretório " + file1.Directory);
      //Console.WriteLine("Completo " + file1.FullName);

      //DirectoryInfo dir1 = new DirectoryInfo(@"C:\Curso\sub");
      //dir1.Create();
      //dir1.MoveTo(@"C:\Curso\submovto");
      //Directory.CreateDirectory(@"C:\Curso\submovto2");
      //Directory.Move(@"C:\Curso\sub", @"C:\Curso\submovto2");

      //DirectoryInfo dir1 = new DirectoryInfo(@"C:\Curso\subdir");
      //dir1.Create();

      //Directory.CreateDirectory(@"C:\Curso\submovto2");

      //SOMENTE ARQUIVO QUE COMECEM COM C E * SIGNIFICA QUALQUER COISA NA SEQUENCIA DEPOIS DO C
      //string[] files = Directory.GetFiles(@"C:\Curso\", "c*");

      //foreach (var item in files)
      //{
      //  Console.WriteLine(item);
      //}

      //FileInfo[] files = dir1.GetFiles("c*");

      //DriveInfo[] drives = DriveInfo.GetDrives();

      //foreach (var item in drives)
      //{
      //  Console.WriteLine("Nome: {0}, Tipo: {1}, Pronto: {2}", item.Name, item.DriveType, item.IsReady);
      //}

      //DriveInfo driveInfo = new DriveInfo(@"C:\");
      //Console.WriteLine(driveInfo.Name);

      string texto = File.ReadAllText(@"C:\Curso\texto.txt");
      Console.WriteLine(texto);

      string[] linhas = { "Text da linha 1", "texto da linha 2" };
      File.WriteAllLines(@"C:\Curso\texto2.txt", linhas);

    }
  }
}
