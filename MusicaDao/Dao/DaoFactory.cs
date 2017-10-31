using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{

  public static class DaoFactory
  {
    public static T CreateDao<T>() where T: Dao, new () //ESTOU DIZENDO QUE PARA UTILIZAR ESSE FACTORY TEM QUE HERDAR DA CLASSE DAO E TAMBÉM TER UM CONSTRUTOR VAZIO
    {
      return new T(); //retorna um novo objeto do tipo genérico T
    }
  }
}
