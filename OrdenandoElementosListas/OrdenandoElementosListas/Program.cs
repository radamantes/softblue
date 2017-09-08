using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoElementosListas
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Tarefa> tarefas = new List<Tarefa>();
      tarefas.Add(new Tarefa() { Descricao = "Lavar louça", Prioridade = Tarefa.Nivel.BAIXA });
      tarefas.Add(new Tarefa() { Descricao = "Varrer a calçada", Prioridade = Tarefa.Nivel.MEDIA });
      tarefas.Add(new Tarefa() { Descricao = "Limpar o chão", Prioridade = Tarefa.Nivel.BAIXA });
      tarefas.Add(new Tarefa() { Descricao = "Fazer compras", Prioridade = Tarefa.Nivel.ALTA });
      tarefas.Add(new Tarefa() { Descricao = "Lavar roupa", Prioridade = Tarefa.Nivel.ALTA });

      //1 FORMA DE COMPARAÇÃO POR PRIORIDADE E POR DESCRIÇÃO
      tarefas.Sort(); //AQUI ELE CHAMA O CompareTo de forma Implícita


      //2 FORMA DE COMPARAÇÃO - COMPARA POR ORDEM ALFABÉTICA
      ComparadoAlfabetico c = new ComparadoAlfabetico();
      tarefas.Sort(c); // AQUI ELE VAI CHAMAR O OUTRO MÉTODO DE COMPARAÇÃO


      foreach (var tarefa in tarefas)
      {
        Console.WriteLine(tarefa);
      }
    }
  }

  public class Tarefa : IComparable<Tarefa>
  {
    public string Descricao { get; set; }
    public Nivel Prioridade { get; set; }

    public enum Nivel
    {
      ALTA = 10,
      MEDIA = 5,
      BAIXA = 0
    }
    public override string ToString()
    {
      return string.Format("{0}-({1})", Descricao, Prioridade);
    }

    public int CompareTo(Tarefa other)
    {
      int c = this.Prioridade.CompareTo(other.Prioridade); //COMPARANDO O ENUM COM O OUTRO OBJETO

      if (c == 0) // C==0 SIGNIFICA QUE AS PRIORIDADES SÃO IGUAIS ENTÃO QUERO FAZER OUTRA COMPARAÇAO NO CASO DESCRIÇÃO
      {
        return this.Descricao.CompareTo(other.Descricao); //AI NESSE CASO ELE FAZ A ORDENAÇÃO POR DESCRIÇÃO QUANDO AS PRIORIDADES SÃO IGUAIS
      }
      return -c; //SE EU COLOCAR C ELE COMEÇA PELAS PRIORIDADES BAIXA SE EU COLOCA -C ELE COMEÇA PELAS PRIORIDADES MAIS ALTAS
    }
  }


  //OUTRA FORMA DE COMPARAÇÃO PORÉM EM ORDEM ALFABÉTICA
  public class ComparadoAlfabetico : IComparer<Tarefa>
  {
    public int Compare(Tarefa x, Tarefa y)
    {
      return x.Descricao.CompareTo(y.Descricao); //AQUI ESTOU COMPARANDO POR ORDEM ALFABÉTICA 
    }
  }
}
