using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relogio
{

  class Program

  {

    static void Main(string[] args)

    {

      //RELÓGIO 1
      

      Relogio relogio = new Relogio();
      relogio.AcertarRelogio(13,30,50);
      
      Console.WriteLine("Posição do Ponteiro da Hora Hora: " + relogio.ponteiroHora.posicao);
      Console.WriteLine("Posição do Ponteiros dos Minutos: " + relogio.ponteiroMinuto.posicao);
      Console.WriteLine("Posição do Ponteiro dos Segundos: " + relogio.ponteiroSegundos.posicao);

     
      //AQUI ELE VAI RETORNAR A POSIÇÃO DO PONTEIRO EM MINUTOS POR EXEMPLO SE relogio.ponteiroSegundos está na posição de um relógio 3 significa que ele está nos 15 SEGUNDOS  pois faz o calculo 3 * 5

      int hora = relogio.LerHora();
      int minutos = relogio.LerMinuto();
      int segundos = relogio.LerSegundo();

      Console.WriteLine( hora + " Hora  - "  + minutos  + " Minutos - " +  segundos + " Segundos " );
      



    }

  }

}