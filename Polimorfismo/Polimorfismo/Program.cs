using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
  class Program
  {
    static void Main(string[] args)
    {
      //Cachorro c = new Cachorro();
      //c.Falar();

      Animal a = new Cachorro();
      //a.Falar();



      // OUTRO MODELO DE CASTING
      //((Cachorro)a).Morder();


      // 1 MODELO DE CASTING UTILIZANDO O OPERADOR IS 
      //if (a is Cachorro)
      //{

      //  //FAZENDO O CASTING CASO VERDADEIRO
      //  Cachorro c = (Cachorro)a;
      //  c.Morder();
      //}
      //else
      //{
      //  Console.WriteLine("Casting não pode ser feito");
      //}
      
      Cachorro c = a as Cachorro;
      
      if (c !=null)
      {
        c.Morder();
      }
      else
      {
        Console.WriteLine("Não pode ser feita a conversão");
      }
      
      //Gato g = new Gato();
      //g.Falar();
    }

  }
  public class Animal
  {
    int status = 10;

    public virtual void Falar()
    {
      Console.WriteLine("---");

    }
  }

  public class Cachorro : Animal
  {
    public override void Falar()
    {
      Console.WriteLine("Au-Au");
    }

    public void Morder()
    {
      Console.WriteLine("Nhac!");
    }
  }

  public class Gato : Animal
  {
    public override void Falar()
    {
      Console.WriteLine("Miau");
    }

  }
}
