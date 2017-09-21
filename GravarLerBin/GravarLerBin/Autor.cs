using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravarLerBin
{
  public class Autor : IRecordable
  {
    public string Name { get; set; }
    public DateTime? Date { get; set; }// Usa um nullable type para permitir a atribuição de null e para tulizar a propriedade Value.Tricks


    public void Read(BinaryReader reader)
    {
      Name = reader.ReadString();
      long time = reader.ReadInt64(); ///AQUI EU LÍ A DATA EM FORMA DE UM LONG
      Date = new DateTime(time); //AQUI EU CRIEI UMA NOVA DATA PASSANDO O LONG COMO PARÂMETRO
    }

    public void Write(BinaryWriter writer)
    {
      writer.Write(Name);
      writer.Write(Date.Value.Ticks);
      
    }
    public override string ToString()
    {
      return String.Format("O Autor é: {0} - Data de Nascimento é: {1} ", Name, Date.Value.ToShortDateString()); //ESSE MÉTODO RETORNA SOMENTE A DATA E NÃO DATA E HORA DO OBJETO DATETIME
    }
  }
}
