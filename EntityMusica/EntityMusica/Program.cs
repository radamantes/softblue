using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMusica
{
  class Program
  {
    static void Main(string[] args)
    {
      SoftblueEntities context = new SoftblueEntities();

      //CriarMusica(context);
      //AlterarMusica(context);
      //RetonarMusica(context);
      Excluir(context);
      
     
    }
    public static void CriarMusica(SoftblueEntities context)
    {
      Musica m = context.Musica.Create();
      m.Album = "Diguindon";
      m.Cantor = "Pararoti";
      m.Titulo = "Lá última canción";
      m.Genero = "Rock";

      context.Musica.Add(m);
      context.SaveChanges();
    }
    public static void RetonarMusica(SoftblueEntities context)
    {
      Musica m = context.Musica.Find(1002);

      Console.WriteLine(m.Titulo);
      
    }
    public static void AlterarMusica(SoftblueEntities context)
    {
      Musica m = context.Musica.Find(1002);
      m.Titulo = "Alterado A última Canção";
      context.SaveChanges();
    }
    public static void Excluir(SoftblueEntities context)
    {
      Musica m = context.Musica.Find(1002);
      context.Musica.Remove(m);
      context.SaveChanges();
    }
  }
}
