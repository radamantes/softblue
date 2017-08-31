using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
  //AQUI ESTOU UTILIZANDO O TIPO GENERICS
  class Lista<T>
  {
    private No<T> primeiro;

    public void Adicionar(T elemento)
    {
      No<T> novoNo = new No<T>();
      novoNo.Elemento = elemento;

      if (primeiro == null)
      {
        primeiro = novoNo;
      }
      else
      {
        No<T> no = primeiro;
        while (no.Proximo != null)
        {
          no = no.Proximo;
        }
        no.Proximo = novoNo;
      }
    }
    public T Ler(int pos)
    {
      if (pos < 0)
      {
        return default(T);
      }
      if (primeiro == null)
      {
        return default(T);
      }
      int count = 0;
      No<T> no = primeiro;

      while (count < pos)
      {
        no = no.Proximo;
        count++;
      }
      return no.Elemento;
    }
  }

  public class No<T>
  {
    public T Elemento { get; set; }
    public No<T> Proximo { get; set; }
  }


  //ESSE É O MODO ANTIGO SEM GENERICS NÃO TEM BOA PERFORMANCE
  //class Lista
  //{
  //  private No primeiro;

  //  public void Adicionar(object elemento)
  //  {
  //    No novoNo = new No();
  //    novoNo.Elemento = elemento;

  //    if (primeiro == null)
  //    {
  //      primeiro = novoNo;
  //    }
  //    else
  //    {
  //      No no = primeiro;
  //      while (no.Proximo != null)
  //      {
  //        no = no.Proximo;
  //      }
  //      no.Proximo = novoNo;
  //    }
  //  }
  //  public object Ler(int pos)
  //  {
  //    if (pos< 0)
  //    {
  //      return null;
  //    }
  //    if(primeiro == null)
  //    {
  //      return null;
  //    }
  //    int count = 0;
  //    No no = primeiro;

  //    while (count < pos)
  //    {
  //      no = no.Proximo;
  //      count++;
  //    }
  //    return no.Elemento;
  //  }
  //}

  //public class No
  //{
  //  public object Elemento { get; set; }
  //  public No Proximo { get; set; }
  //}
}
