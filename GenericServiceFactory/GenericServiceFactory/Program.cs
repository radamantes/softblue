using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServiceFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      ServiceFactory<MyClassTeste> s = new ServiceFactory<MyClassTeste>();
      MyClassTeste mc = s.newInstance(); // AQUI É COMO SE EU TIVESSE FAZENDO =  new MyClassTeste  e atribuir a uma váriavel do mesmo tipo

      mc.Execute();

    }
  }

  class ServiceFactory<T> where T : IService, new() //aqui eu restringir, deve ter um construtor vazio = new()  e também deve implementar a interface IService
  {
    public T newInstance()
    {
      return new T(); //ESSA CHAMADA ELE IRÁ RETORNAR QUALQUER NOVO TIPO DE UM OBJETO DESDE QUE CUMPRA COM OS REQUISÍTOS ACIMA.
    }
  }
  class MyClassTeste : IService
  {
    public void Execute()
    {
      Console.WriteLine("Implementando a interface Iservice");
    }
  }
  public interface IService
  {
    void Execute();
  }
}
