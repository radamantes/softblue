using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLampada
{
  class Program
  {
    static void Main(string[] args)
    {
      Lampada lampada = new Lampada(true);
      lampada.Ligar();
      lampada.Imprimir();
      lampada.Desligar();
      lampada.Imprimir();
      lampada.Ligar();
      lampada.Imprimir();
    }

    public class Lampada
    {
      private bool ligada;

      //PROPRIEDADE
      //public bool Ligada
      //{
      //  get { return ligada; }
        //set { ligada = value; }
      //}

      public Lampada(bool statusLampada)
      {
        ligada = statusLampada;
      }

      public void Ligar()
      {
        ligada = true;
      }

      public void Desligar()
      {
        ligada = false;
      }
      public void Imprimir()
      {
        string status;
        if (ligada == true)
          status = "Ligada";
        else
          status = "Desligada";

        Console.WriteLine("Lampada está " + status);
      }

    }
  }
}
