using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{

  public class DivisaoException : Exception
  {
    public DivisaoException() { }
    public DivisaoException(string message) : base(message) { }
    public DivisaoException(string message, Exception inner) : base(message, inner) { }
  }

  public class CaculoException : Exception
  {
    public CaculoException() { }
    public CaculoException(string message) : base(message) { }
    public CaculoException(string message, Exception inner) : base(message, inner) { }
  }
}
