using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
  class Program
  {
    static void Main(string[] args)
    {


      //Cafe c = new Cafe();
      //c.Preparar();

      Caipirinha caipi = new Caipirinha();
      caipi.Preparar();

      //Animal g = new Gato();
      //g.Falar();
    }

  }
  public abstract class Bebida
  {
    public void Preparar()
    {
      Console.WriteLine("Inicio da Preparação");
      AdicionarAguar();
      AdicionarSubstancia();
      AdicionarAcucar();
      Console.WriteLine("Bebida Pronta");
    }
    public abstract void AdicionarAguar();

    public abstract void AdicionarSubstancia();

    public abstract void AdicionarAcucar();
  }
  public class Cafe : Bebida
  {
    public override void AdicionarAcucar()
    {
      Console.WriteLine("Adicionando Açúcar");
    }

    public override void AdicionarAguar()
    {
      Console.WriteLine("Adicionando Agua");
    }

    public override void AdicionarSubstancia()
    {
      Console.WriteLine("Adicionando Café");
    }
  }


  public class Caipirinha : Bebida
  {
    public override void AdicionarAcucar()
    {
      Console.WriteLine("Adicionando Açúcar");
    }

    public override void AdicionarAguar()
    {
      Console.WriteLine("Adicionando Pinga");
    }

    public override void AdicionarSubstancia()
    {
      Console.WriteLine("Adicionando Limão");
    }
  }

  //public abstract class Animal
  //{
  //  public abstract void Falar();
  //}

  //class Gato : Animal
  //{
  //  public override void Falar()
  //  {
  //    Console.WriteLine("Miau");
  //  }
  //}

  //class Cachorro : Animal
  //{
  //  public override void Falar()
  //  {
  //    Console.WriteLine("Au-Au");
  //  }
  //}
}
