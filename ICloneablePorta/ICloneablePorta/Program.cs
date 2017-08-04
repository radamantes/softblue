using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneablePorta
{
  class Program
  {
    static void Main(string[] args)
    {
        
      //CRIO PORTA 1
      Porta p1 = new Porta(1.95, 0.90);
               
      p1.Abrir(); //lembrando que a referenci ao objeto é a mesma então se altera em um objeto altera no outro;
      
      Console.WriteLine(" P1 " + " -> Altura = " + p1.Altura);
      Console.WriteLine(" P1 " + " -> Altura = " + p1.Largura);
      Console.WriteLine(" P1 " + " -> Altura = " + p1.Aberta);



      //CRIO O CLONE DA PORTA 1
      Porta p2 = (Porta)p1.Clone(); //define para p2 o clone do objeto p1 a mesma referencia // FIZ O CASTINGO POIS RETORNA UM OBJETO ENTÃO TEMOS QUE DIZER QUAL É O TIPO DO OBJETO NO CASO PORTA

      Console.WriteLine(" P2 " + " -> Altura  = " + p2.Altura);
      Console.WriteLine(" P2 " + " -> Altura  = " + p2.Largura);
      Console.WriteLine(" P2 " + " -> Altura  = " + p2.Aberta);

    }

    public class Porta : ICloneable
    {
      private double altura;
      private double largura;
      private bool aberta;


      public double Altura
      {
        get { return altura; }
      }

      public double Largura
      {
        get { return largura; }
      }

      public bool Aberta
      {
        get { return aberta; }
      }

      public Porta(double altura, double largura)
      {
        this.altura = altura;
        this.largura = largura;
      }

      public object Clone()
      {
        return this; //RETORNA A REFERENCIA DO OBJETO
      }

      public void Fechar()
      {

        aberta = false;

      }
      public void Abrir()
      {
        aberta = true;
      }


    }
  }
}
