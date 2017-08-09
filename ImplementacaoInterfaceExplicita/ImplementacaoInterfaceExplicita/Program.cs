using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacaoInterfaceExplicita
{
  class Program
  {
    static void Main(string[] args)
    {
      Object o = new Objeto();
      // o.EmitirSom(); //nao funciona

      //IAnimal a = (IAnimal)o;
      //a.EmitirSom();

      //POSSO CONVERTER TAMBÉM DESSA FORMA
      //IBrinquedo b = (IBrinquedo)o;
      //b.EmitirSom();


      //POSSO CONVERTER DESSA FORMA
      ((IBrinquedo)o).EmitirSom();
    }
  }

  public interface IAnimal
  {
    void EmitirSom();
  }

  public interface IBrinquedo
  {
    void EmitirSom();
  }


  public class Objeto : IAnimal, IBrinquedo
  {
    void IAnimal.EmitirSom()
    {
      Console.WriteLine("Animal Emitiu Som");
    }

    void IBrinquedo.EmitirSom()
    {
      Console.WriteLine("Brinquedo Emitiu Som");
    }
  }
}

