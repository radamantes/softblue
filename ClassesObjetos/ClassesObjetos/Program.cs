using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
  class Program
  {
    static void Main(string[] args)
    {

      //CONTA NÚMERO 1
      Conta c1 = new Conta();
      c1.nome = "Diego";
      c1.saldo = 1500;
      c1.numeroConta = 159;

      Console.WriteLine("Nome do Cliente 1: " + c1.nome);
      Console.WriteLine("Saldo atual: " + c1.saldo);


      //-------------------------------------------------------

      //CONTA NÚMERO 2
      Conta c2 = new Conta();
      c2.nome = "Raquel";
      c2.saldo = 700;
      c2.numeroConta = 741;


      Console.WriteLine("Nome do Cliente 2: " + c2.nome);
      Console.WriteLine("Saldo atual: " + c2.saldo);

      int valorParaSacar = 200; //VALOR PARA SAQUE
      int valorParaTransferir = 125; //VALOR PARA TRANSFERENCIA

                 

      c1.Sacar(valorParaSacar);
      c1.Transferir(valorParaTransferir, c2);
          
      Console.WriteLine(c1.nome + " Sacou: " + valorParaSacar);
   
      Console.WriteLine(c1.nome + " Transferiu " +  valorParaTransferir + " para " + c2.nome);
      
      Console.WriteLine("Restou na conta de " + c1.nome + " " + c1.Saldo());

      Console.WriteLine("Restou na conta de " + c2.nome + " " + c2.Saldo());

      

    }
  }
}
