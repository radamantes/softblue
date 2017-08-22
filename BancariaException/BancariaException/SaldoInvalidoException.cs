using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancariaException
{
  // Exceção que representa uma quantidade de saldo insuficiente na conta para realizar a transação
  class SaldoInsuficienteException : Exception
  {
    // Saldo total disponível na conta
    private double saldoDisponivel;

    // Construtor. Recebe uma mensagem de erro e o saldo disponível
    public SaldoInsuficienteException(String message, double saldoDisponivel)
        : base(message)
    {
      this.saldoDisponivel = saldoDisponivel;
    }

    // Obtém o saldo disponível
    public double SaldoDisponivel
    {
      get { return saldoDisponivel; }
    }
  }
}

