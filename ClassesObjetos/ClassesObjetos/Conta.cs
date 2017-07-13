using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
  class Conta
  {
    public string nome;
    public int saldo;
    public int numeroConta;

    public void Sacar(int vpSaque)
    {
      saldo -= vpSaque;
    }

    public int Saldo()
    {
      return saldo;
    }

    public void Depositar(int valor)
    {
      saldo += valor;
    }

    public void Transferir(int vpTranferencia, Conta contraTransferida)
    {
      Sacar(vpTranferencia);
      contraTransferida.Depositar(vpTranferencia); //RECEBER O VALOR A SER TRANSFERIDO E ACRESCENTA EM SUA CONTA

    }
  }

}
