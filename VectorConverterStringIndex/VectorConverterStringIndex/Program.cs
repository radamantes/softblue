using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorConverterStringIndex
{
  class Program
  {
    static void Main(string[] args)
    {
      // Cria um vetor e atribui as coordenadas.
      Vector v = new Vector();
      v['X'] = 5;
      v['Y'] = 7;
      int x = v['X'];
      int y = v['Y'];

      Console.WriteLine("X = " + x + ", Y = " + y);

      //Faz o casting para string de form implícita.
      string s = v;

      Console.WriteLine(s);

    }

    public class Vector
    {
      public int x;
      public int y;

      // Indexador com base em 'X' ou 'Y'.
      public int this[char coord]
      {
        get
        {
          if (coord == 'X')
          {
            return x;
          }
          else if (coord == 'Y')
          {
            return y;
          }

          throw new ArgumentException("Coordenada inválida");
        }
        set
        {
          if (coord == 'X')
          {
            x = value;
          }
          else if (coord == 'Y')
          {
            y = value;
          }
          else
          {
            throw new ArgumentException("Coordenada inválida");
          }
        }
      }             //string = TIPO DE DADOS DE DESTINO   // Vector v = tipo de dados de origem
      public static implicit operator string(Vector v)
      {
        return " " + v.x + " " + v.y; //RETORNO UMA STRING
      }
    }
  }
}
