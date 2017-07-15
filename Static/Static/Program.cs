using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
  //tudo que é estático, está associado a classe e nao aos objetos da classe

  class Program
  {
    static void Main(string[] args)
    {
      Bola b1 = new Bola();
      Console.WriteLine(Bola.numBola);

      Bola b2 = new Bola();
      Console.WriteLine(Bola.numBola);

      //Matematica m = new Matematica();
      //int soma = m.Somar(22, 35);
      int soma = Matematica.Somar(22, 35);
      Console.WriteLine(soma);
    }
  }
  class Bola
  {
    public static int numBola;

    public Bola()
    {
      numBola++;
    }
  }
  class Matematica
  {
    static int resultado;

    //USANDO A PALAVRA STATIC EU FAÇO O OBJETO PETENCER A CLASSE MATEMÁTICA E NÃO A UM OBJETO POR EXEPLO MATEMATIC M = NEW MATEMATICA NÃO VAI FUNCIONAR
    public static int Somar(int a, int b)
    {
      return a + b;
    }
    
    //ELEMENTO ESTÁTICOS NÃO TEM RELALÃO COM OBJETOS
    public static void Somar(int a, int b, int c)
    {
      resultado = a + b;
    }
  }
}
