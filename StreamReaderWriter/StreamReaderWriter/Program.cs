using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderWriter
{
  class Program
  {
    static void Main(string[] args)
    {

      //PROCESSO DE ESCRITA
      //PRIMEIRA FORMA
      //FileStream fs = new FileStream(@"C:\Curso\Diego.txt", FileMode.Create, FileAccess.Write);
      //StreamWriter sw = new StreamWriter(fs); //PARA ESCREVER NO ARQUIVO


      //SEGUNDA FORMA DO PROCESSO DE ESCRITA
      //FileInfo fi = new FileInfo(@"C:\Curso\Diego.txt");
      //StreamWriter sw = fi.CreateText();

      //sw.Write("Olá, este é um texto de exemplo.\n");
      //sw.Close();

      //PROCESSO DE LEITURA
      FileInfo fi = new FileInfo(@"C:\Curso\Diego.txt");
      StreamReader sr = fi.OpenText();//ABRINDO O ARQUIVO PARA LEITURA


      //1 FORMA DE LEITURA DE TODO O ARQUIVO TXT
      //string leitura;
      //while ((leitura = sr.ReadLine()) != null)//ENQUANTO EXISTIR LINHAS PARA SEREM LINHAS IRÁ EXECUTAR O CÓDIGO 
      //{
      //  Console.WriteLine(leitura);
      //}


      //2 FORMA DE LEITURA DE TODO O ARQUIVO TXT
      string leitura = sr.ReadToEnd();
      Console.WriteLine(leitura);

      


      sr.Close();
    }
  }
}
