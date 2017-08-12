using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
  class Program
  {
    static void Main(string[] args)
    {
      //CRIA MOTO
      Veiculo v = new Motocicleta();
      v.Ligar();
      Console.WriteLine(v.Ligado);
      v.Apagar();
      Console.WriteLine(v.Ligado);

      //CRIA ONIBUS
      Veiculo o = new Onibus();
      o.Ligar();
      Console.WriteLine(o.Ligado);
      o.Apagar();
      Console.WriteLine(o.Ligado);

      //CRIA AUTOMÓVEL
      Veiculo a = new Automovel();
      a.Ligar();
      Console.WriteLine(a.Ligado);
      a.Apagar();
      Console.WriteLine(a.Ligado);
    }
  }

  public class Veiculo
  {
    private bool ligado;


    //READ ONLY PROPERTY
    public bool Ligado
    {
      get { return ligado; }
    }

    public virtual void Ligar()
    {
      ligado = true;
    }
    public virtual void Apagar()
    {
      ligado = false;
    }

  }

  public class Motocicleta : Veiculo
  {
    public override void Ligar()
    {
      base.Ligar(); //ANTES ELE CHAMA O MÉTODO DA CLASSE PAI E DEPOIS lhe subrescreve
      Console.WriteLine("Ligando Moto");
    }

    public override void Apagar()
    {
      base.Apagar();
      Console.WriteLine("Apagando Moto");
    }
  }
  public class Onibus : Veiculo
  {
    public override void Ligar()
    {
      base.Ligar();
      Console.WriteLine("Ligando Ônibus");
    }

    public override void Apagar()
    {
      base.Apagar();
      Console.WriteLine("Apagando Ônibus");
    }
  }
  public class Automovel : Veiculo
  {
    public override void Ligar()
    {
      base.Ligar();
      Console.WriteLine("Ligando Automóvel");
    }

    public override void Apagar()
    {
      base.Apagar();
      Console.WriteLine("Apagando Automóvel");
    }

  }
}
