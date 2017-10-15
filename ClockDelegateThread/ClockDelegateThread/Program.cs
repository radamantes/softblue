using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClockDelegateThread
{
  class Program
  {
    static void Main(string[] args)
    {
      Clock c = new Clock();
      c.AdicionarCallBack(OnSecond);
      c.Start();
        
    }

    static void OnSecond(long tempo)
    {
      Console.WriteLine("Tempo passado: " + tempo);
    }
  }


  public delegate void SecondsHandler(long tempo);

  class Clock
  {
    long time = 0;

    SecondsHandler callbacks;
    
    public void Start()
    {
      while (true)
      {
        time++;
        callbacks(time);
        Thread.Sleep(1000);
      }
    }
    public void AdicionarCallBack(SecondsHandler handler)
    {
      callbacks += handler;
    }
  }
 
}
