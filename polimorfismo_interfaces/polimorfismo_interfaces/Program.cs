using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_interfaces
{
  class Program
  {
    static void Main(string[] args)
    {

      Selo s = new Selo();

      //IColectionavel c = new Selo();
      ImprimirColecao(s);

      Bone b = new Bone();
      ImprimirColecao(b);
    }

    static void ImprimirColecao(IColectionavel c)
    {
      Console.WriteLine("Esta é uma coleção de : " + c.GetNomeColecao());
    }
  }
  public interface IColectionavel
  {
    string GetNomeColecao();
  }

  public class Selo : IColectionavel
  {
    public string GetNomeColecao()
    {
      return "Selos";
    }
  }

  public class Bone : IColectionavel
  {
    public string GetNomeColecao()
    {
      return "Bonés";
    }
  }
}
