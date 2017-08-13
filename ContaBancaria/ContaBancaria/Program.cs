using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
  class Program
  {
    static void Main(string[] args)
    {

      //CRIA OBJETO CONTA CORRENTE
      ContaBancaria c = new ContaCorrente();


      //CONTA INVESTIMENTO
      ContaBancaria i = new ContaInvestimento();



      //MOVIMENTAÇÕES CONTA CORRENTE
      c.Depositar(700);
      c.Sacar(100);
      c.Transferir(i, 200);// TRANFERIU 200 PARA CONTA INVESTIMENTO
      c.CalcularSaldo();


      //MOVIMENTAÇÕES CONTA INVESTIMENTO
      i.Depositar(1500);
      i.CalcularSaldo();


      Console.WriteLine("Seu saldo em sua conta corrente é: " + c.Saldo);
      Console.WriteLine("Seu saldo em sua conta investimento é:  " + i.Saldo);


    }
  }

  public abstract class ContaBancaria
  {
    public double Saldo { get; set; }


    public void Depositar(double valor)
    {
      Saldo += valor;
    }

    public void Sacar(double valor)
    {
      Saldo -= valor;
    }

    public void Transferir(ContaBancaria conta, double valor)
    {
      Sacar(valor); //saca o valor da conta que o chamou
      conta.Saldo += valor; // DEPOSITA NA OUTRA CONTA
    }

    public abstract double CalcularSaldo();

  }

  //CLASSE CONTA CORRENTE HERDANDO DE CONTA BANCARIA E SUBSCREVENDO SEUS MÉTODOS
  public class ContaCorrente : ContaBancaria
  {
    public override double CalcularSaldo()
    {
      return Saldo -= Saldo * 0.10; // REMOVENDO 10 POR CENTO DO SALDO ATUAL
    }

    public void Depositar(double valor)
    {
      base.Depositar(valor);
    }

    public void Sacar(double valor)
    {
      base.Sacar(valor);
    }

    public void Transferir(ContaBancaria conta, double valor)
    {
      base.Transferir(conta, valor);
    }
  }

  //CLASSE CONTA INVESTIMENTO HERDANDO DA CONTA BANCÁRIA E SUBSCREVENDOS SEUS MÉTODOS
  public class ContaInvestimento : ContaBancaria
  {
    public override double CalcularSaldo()
    {
      return Saldo += Saldo * 0.05; // ADICIONANDO 5 POR CENTO AO SALDO FINAL
    }

    public void Depositar(double valor)
    {
      base.Depositar(valor);
    }

    public void Sacar(double valor)
    {
      base.Sacar(valor);
    }

    public void Transferir(ContaBancaria conta, double valor)
    {
      base.Transferir(conta, valor);
    }
  }
}
