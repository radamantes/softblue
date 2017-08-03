using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testenovo
{

  public class Carro : IMotorizado, IRoubar
  {
    public string NomeMotor
    {
      get { return NomeMotor; }
      set { NomeMotor = value; }
    }

    public void Frear()
    {
      Console.WriteLine("Freando Carro");
    }
    public void Ligar()
    {
      Console.WriteLine("Ligando o carro");
    }
    public void Roubar()
    {
      Console.WriteLine("Roubou o carro");
    }

  }

  interface IRoubar
  {
    //string statusRoubo { get; set; }
    void Roubar();
  }

  interface IMotorizado : IFrear
  {
    void Ligar();
    string NomeMotor { get; set; }
  }
  interface IFrear
  {
    void Frear();
  }
}
