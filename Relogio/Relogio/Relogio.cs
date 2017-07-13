using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relogio
{
  public class Relogio
  {

    
    public Ponteiro ponteiroHora = new Ponteiro();
    public Ponteiro ponteiroMinuto = new Ponteiro();
    public Ponteiro ponteiroSegundos = new Ponteiro();

    

    // Acerta o relógio, posicionando adequadamente cada ponteiro do relógio.Os parâmetros passados são hora, minuto e segundo.
    public void AcertarRelogio(int hora, int minuto, int segundo)
    {
      // A linha abaixo calcula o módulo da hora. Assim, se for fornecido 13, por exemplo, é considerado hora 1.

      hora = hora % 12;

      ponteiroHora.posicao = hora;
      ponteiroMinuto.posicao = minuto / 5;
      ponteiroSegundos.posicao = segundo / 5;
    }

    // retorna a hora atual do relógio.
    public int LerHora()
    {
      return ponteiroHora.posicao;
    }

    // retorna o minuto atual do relógio.
    public int LerMinuto()
    {
      return ponteiroMinuto.posicao * 5;
    }

    // retorna o segundo atual do relógio.
    public int LerSegundo()
    {
      return ponteiroSegundos.posicao * 5;
    }
  }
}
