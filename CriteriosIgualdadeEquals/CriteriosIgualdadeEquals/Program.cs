using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriteriosIgualdadeEquals
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "abc";
      string s2 = "abc";

      int i1 = 10;
      int i2 = 11;

      //COMPARANDO AS STRINGS
      Console.WriteLine(string.Equals(s1,s2));
      //Console.WriteLine(s1.Equals(s1));

      //COMPARANDO OS INT
      Console.WriteLine(int.Equals(i1,i2));
      //Console.WriteLine(i1.Equals(i2));

      Aluno a1 = new Aluno("Pedro");
      Aluno a2 = new Aluno("Pedro");

      Console.WriteLine(a1.Equals(a2));
    }
  }
  public class Aluno : System.IEquatable<Aluno>
  {
    public string Nome { get; set; }

    public Aluno(string nome)
    {
      this.Nome = nome;
    }
    public override bool Equals(object obj)
    {
      return Equals(obj as Aluno);//CHAMA O MÉTODO DEBAIXO
    }

    public bool Equals(Aluno other)
    {
      if (other == null)
      {
        return false;
      }
      return this.Nome.Equals(other.Nome);
    }
  }
}
