using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont = 0;
            double soma = 0;
            double peso = 0;

            

            while (true)
            {
                Console.WriteLine("Digita uma nota");
                double nota = double.Parse(Console.ReadLine());


                // AQUI CASO A NOTA DIGITADA SEJA -1 ELE SAI DE TUDO
                if(nota == -1)
                {
                    break;
                }

                //ELE SEMPRE IRÁ EXECUTAR ESSE CÓDIGO CASO A NOTA NÃO SEJA IGUAL -1
                Console.WriteLine("Digite um peso");
                peso = double.Parse(Console.ReadLine());

                //AQUI ELE FAZ A SOMA DO QUE JÁ TINHA MAIS NOTA MULTIPLICADO PELO PESO
                soma += nota * peso;

                //PARA CONTAS AS NOTAS PARA DEPOIS SER DIVIDIDO
                cont++;

            }
            
            Console.WriteLine("Média das notas é " + soma / cont );

        }
    }
}
