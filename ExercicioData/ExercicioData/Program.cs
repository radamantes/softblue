using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioData
{
  class Program
  {
    static void Main(string[] args)
    {
      Data d1 = new Data(10, 3, 2016, 30, 14, 13);

      d1.Imprimir(Data.FORMATO_12H);
      d1.Imprimir(Data.FORMATO_24H);


      Data d2 = new Data(10, 3, 2016);
      d2.Imprimir(Data.FORMATO_12H);

    }

    public class Data
    {
      //DATA
      private int dia;
      private int mes;
      private int ano;

      //HORA
      public int segundo { get; private set; }
      public int minuto { get; private set; }
      public int hora { get; private set; }


      //CONSTANTES JÁ SÃO INICIALIZADOS COMO STATIC OU SEJA NÃO PRECISO INSTANCIAR 
      public const int FORMATO_12H = 12;
      public const int FORMATO_24H = 24;


      public int Dia
      {
        get { return dia; }
        set { dia = value; }
      }

      public int Mes
      {
        get { return mes; }
        set { mes = value; }
      }

      public int Ano
      {
        get { return ano; }
        set { ano = value; }
      }

      public Data(int dia, int mes, int ano)
      {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
      }

      public Data(int dia, int mes, int ano, int segundo, int minuto, int hora) : this(dia, mes, ano) //IRÁ INVOCAR O CONSTRUTOR QUE TEM COMO PARAMATRO DIA, MES Y ANO E DEPOIS EXECUTAR ESSE CONSTRUTOR
      {
        this.segundo = segundo;
        this.minuto = minuto;

        if (hora >= 0 && hora <= 23)
          this.hora = hora;
        else
        {
          this.hora = 0;
          this.segundo = 0;
          this.minuto = 0;
        }

      }
      public void Imprimir(int formato)
      {
        //ATRIBUI SEGUNDO IGUAL A 0 CASO NÃO TENHA PASSADO UMA HORA ENTÃO SEGUNOD HORA E MINUTOS RECEBEM 0
        if (segundo == 0)
        {
          Console.WriteLine(dia + "/" + mes + "/" + ano);
        }
        else
        {
          string status = null;

          if (formato == 12)
          {
            if (hora >= 13)
            {
              int horaSaida = hora - 12;

              status = "PM";
              {
                Console.WriteLine(dia + "/" + mes + "/" + ano + " " + horaSaida + ":" + minuto + ":" + segundo + " " + status);
              }
            }
            else
            {
              status = "AM";
              {
                Console.WriteLine(dia + "/" + mes + "/" + ano + " " + hora + ":" + minuto + ":" + segundo + " " + status);
              }
            }
          }
          if (formato == 24)
          {
            if (hora >= 13)
            {
              {
                Console.WriteLine(dia + "/" + mes + "/" + ano + " " + hora + ":" + minuto + ":" + segundo + " " + status);
              }
            }
            else
            {
              status = "AM";
              {
                Console.WriteLine(dia + "/" + mes + "/" + ano + " " + hora + ":" + minuto + ":" + segundo + " " + status);
              }
            }
          }
        }
      }
    }
  }
}

