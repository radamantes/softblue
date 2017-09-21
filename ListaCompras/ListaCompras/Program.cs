using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListaCompras
{
  class Program
  {
    static void Main(string[] args)
    {
      String listaCompras;


      //AQUI VERIFICAR SE O ARQUIVO EXISTE
      if (File.Exists(@"C:\Curso\ListaCompras.txt"))
      {
        Console.WriteLine("Essa é sua última lista de compras");

        FileInfo fi = new FileInfo(@"C:\Curso\ListaCompras.txt");
        StreamReader sr = fi.OpenText();
        Console.WriteLine(sr.ReadToEnd());
        sr.Close();
      }
      //CASO O ARQUIVO NÃO EXISTA ELE CRIA O ARQUIVO
      else
      {
        FileStream fs = new FileStream(@"C:\Curso\ListaCompras.txt", FileMode.Create);
        fs.Close();
      }
      while (true)
      {
        Console.Write("Digite um iten para sua lista de compras ou 0 para sair do aplicativo: ");
        listaCompras = Console.ReadLine();


        //ENQUANTO LISTACOMPRAS FOR DIFENTE DE 0 ELE CONINTUA EXECUTANDO A APLICAÇÃO SE O USUÁRIO DIGITA 0 SAI DA APLICAÇÃO
        if (listaCompras == "0")
        {
          break;
        }

        //AQUI VERIFICAR SE MINHA VARIÁVEL STRING É VAZIA OU NULA - CASO O USUÁRIO DIGITE UM VALOR NULO OU VAZIO ELE RETORNA NO COMEÇO DO WHILE PEDINDO PARA DIGITAR OUTRO VALOR
        else if (String.IsNullOrEmpty(listaCompras))
        {
          continue;
        }
        else
        {
          FileStream fs = new FileStream(@"C:\Curso\ListaCompras.txt", FileMode.Append, FileAccess.Write);
          StreamWriter sw = new StreamWriter(fs);
          sw.WriteLine(listaCompras);
          sw.Close();
        }
      }
    }
  }
}

