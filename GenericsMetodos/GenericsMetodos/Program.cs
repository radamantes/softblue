using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMetodos
{
  class Program
  {
    static void Main(string[] args)
    {
      
      int s = Creator.Create<int>();
    }
  }

  class Creator
  {
    public static T Create<T>() where T : new()
    {
      return new T();
    }
  }
}
