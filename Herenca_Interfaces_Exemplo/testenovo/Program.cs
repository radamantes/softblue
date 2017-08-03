using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testenovo;

class Program
{
  static void Main(string[] args)
  {
    Passaro p = new Passaro(7);

    Carro carro = new Carro();
    carro.Ligar();
    carro.Roubar();
    carro.Frear();

  }

  public class Animal
  {
    public Animal()
    {
      Console.WriteLine("Criando um animal ");
    }

    public Animal(int n)
    {
      Console.WriteLine("Criando um animal " + n);
    }
  }

  public class AnimalAlado : Animal
  {
    public AnimalAlado()
    {
      Console.WriteLine("Criando um animal alado ");
    }
    public AnimalAlado(int n) : base(n) //ESSE CHAMA O CONTRUTOR DE ANIMAL PASSANDO O PARAMETRO 3 SE OMITIRMOS O VALOR BASE SERÁ CHAMADO O CONTRUTOR VAZIO DA CLASSE ANIMAL
    {
      Console.WriteLine("Criando um animal alado " + n);
    }
    public AnimalAlado(string nome)
    {
      Console.WriteLine("Imprimindo o nome do Animal Alado " + nome);
    }
  }

  public class Passaro : AnimalAlado // ESSE CHAMA O CONSTRUTOR AnimalAlado PASSANDO O PARAMETRO 3
  {
    public Passaro(int n) : base() //CHAMA O CONTRUTOR DE SUA CLASSE MÃEO QUE NO CASO É ANIMAL ALADO
    {
      Console.WriteLine("Criando um pássaro");
    }
  }
}

