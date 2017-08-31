using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RetringirDadosGenerics
{
  class Program
  {
    static void Main(string[] args)
    {
      //Creator<StringBuilder> c1 = new Creator<StringBuilder>();
      //StringBuilder sb = c1.Create(); //RETORNA UM OBJETO NEW STRINGBUILDER

      //ESSE NÃO PODE SER CRIADO PQ É UM valueType
      //Creator<int> c2 = new Creator<int>();
      //int s = c2.Create(); //CRIOU UM OBJETO INT
      Creator<MyClass> c3 = new Creator<MyClass>();
      MyClass mc = c3.Create();
      
    }
  }

  public class Creator<T> where T : class, IInitiazable, new() //restringindo = onde t tenha um construtor sem parâmetros, e também tem que ser referenceType por causa da palavra class, usando a palabra struc você define que deve ser um valueType
  {
    public T Create()
    {
      T obj = new T();
      obj.Init();
      return obj;
      //return new T();
    }
  }

  public interface IInitiazable
  {
    void Init();
  }

  public class MyClass : IInitiazable
  {
    public void Init()
    {
      Console.WriteLine("Implementando");
    }
  }
}
