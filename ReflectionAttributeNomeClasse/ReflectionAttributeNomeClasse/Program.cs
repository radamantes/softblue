using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Softblue
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite o nome de uma classe: "); //TEM QUE DIGITAR O FULL QUALIFY NAME POR EXEMPLO Softblue.Teste
      string nomeClasse = Console.ReadLine();

      Type t = null;

      if (Type.GetType(nomeClasse) != null)
      {
        t = Type.GetType(nomeClasse); //SE EXISTE O NOME DA CLASSE ATRIBUO AO TYPE T
      }
      else
      {
        Console.WriteLine("Essa classe não existe"); //SE NÃO EXISTE O NOME DA CLASSE DIGITADO PELO USUÁRIO CANCELA A APLICAÇÃO;
        return;
      }

      //AQUI VERIFICO TODOS OS MÉTODOS DA CLASSE DIGITADO PELO USUÁRIO;
      MethodInfo[] methods = t.GetMethods(); //AQUI ELE IRÁ CONTER UMA LISTA DE NÚMEROS COM OS MÉTODOS POR EXEMPLO 0-1-2-3-4 EXEMPLO 0=MostrarNome, 1=Teste() exemplos
                                             

      int cont = 0; //UTILIZADO PARA MOSTAR O NÚMERO RELACIONADO A CADA MÉTODO

         
      foreach (var method in methods)
      {
        Console.WriteLine(cont++ + " - Métodos : " + method.Name + " ");
      }

      Console.WriteLine("Qual o método que você gostaria de chamar: ");
      int metodoCall = int.Parse(Console.ReadLine()); //VARIÁVEL PARA DEFINIR UM NÚMERO PARA SER CHAMADO NO MÉTODO OS MÉTODOS VÃO ESTAR NÚMEROS POIS FAZEM PARTE DE UMA LISTA OBTIDA EM VOCÊ DEBUGAR O CÓDIGO MethodInfo[] methods = t.GetMethods()

      
      MethodInfo opcaoEscolhida = methods[metodoCall]; //AQUI ELE IRÁ GUARDA O NOME DO MÉTODO A SER CHAMADO



      // ARMAZENA EM UM ARRAY VALUES A QUANTIDADE DE PARÂMETROS DO MÉTODO QUE ELE ESCOLHEU E O MÉOTOD TEM SÓ UM PARÂMETRO ARMAZENA SOMENTE 1 SE TEM 2 ARMAZENA 2
      string[] values = new string[opcaoEscolhida.GetParameters().Length];

      foreach (ParameterInfo parameter in opcaoEscolhida.GetParameters())
      {
        //MOSTRAR NA TELA DE UMA FORMA MAIS AMIGÁVEL
        Console.Write("Valor do parâmetro {0} ({1}): ", parameter.Position + 1, parameter.ParameterType);

        //Armazena no array o valor de cada parâmetro digitado pelo usuário.tem que ser string
        //AQUI ELE ATRIBUIR O VALOR PASSADO PARA A VARIÁVEL VALUES ACIMA, UTILIZANDO ESSA PROPRIEDADE POSITION ELE VAI IR DE ACORDO COM A QUANTIDADE DE PARÂMETRO QUE O MÉTODO POSSUI
        values[parameter.Position] = Console.ReadLine(); 
      }      

      object obj = Activator.CreateInstance(t);//CRIAR A INSTANCIA DO OBJETO
      opcaoEscolhida.Invoke(obj, values);//CHAMA O MÉTODO PRIMEIRO PARÂMETRO É O OBJETO E O SEGUNDO PARÂMETRO SÃO OS PARÂMETROS ENVIADO PARA O  METODO QUE FORAM DEFINIDOS PELO USUÁRIOS

    }
  }

  public class Teste
  {
    public void MostrarNome(string y, string x)
    {
      Console.WriteLine("Nome  é: " + y + x);
    }

    public void MostrarSobrenome(string sobrenone)
    {
      Console.WriteLine("Sobrenome é: " + sobrenone);
    }
  }
}
