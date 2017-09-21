using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravarLerBin
{
  public class Livro : IRecordable
  {
    public string Titulo { get; set; }
    public int NumPaginas { get; set; }
    public Autor autor { get; set; }

    public void Read(BinaryReader reader)
    {
      Titulo = reader.ReadString();
      NumPaginas = reader.ReadInt32();
    }

    public void Write(BinaryWriter writer)
    {
      writer.Write(Titulo);
      writer.Write(NumPaginas);
    }
    public override string ToString()
    {
      return String.Format("Titulo é: {0} - Número de Páginas - {1} ", Titulo, NumPaginas);
    }
  }
}
