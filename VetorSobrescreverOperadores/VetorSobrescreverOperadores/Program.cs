using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorSobrescreverOperadores
{
  class Program
  {
    static void Main(string[] args)
    {
      Vector v1 = new Vector(2, 3);
      Vector v2 = new Vector(4, 5);
      Vector v3 = v1 + v2;

      Vector v4 = v3 * 3;

//    Console.WriteLine(v3);

      Console.WriteLine(v4);

    }

    public struct Vector
    {
      private int x;
      private int y;


      public Vector(int x, int y) : this()
      {
        this.x = x;
        this.y = y;
      }
      public static Vector operator *(Vector v, int num)
      {
        return new Vector(v.x * num, v.y * num); //AQUI SÃO OS PARâMETROS DO CONSTRUTOR DE VECTOR
      }

      public static Vector operator +(Vector v1, Vector v2)
      {
        return new Vector(v1.x + v2.x, v1.y + v2.y); //AQUI SÃO OS PARâMETROS DO CONSTRUTOR DE VECTOR
      }

      public override string ToString()
      {
        return "(" + x + " - " + y + ")"; 
      }
    }

  }
}
