using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBTAINING SCORE 1 AND WEIGHT 1
            Console.WriteLine("Type the first score");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the first score's weight");
            double peso1 = double.Parse(Console.ReadLine());

            //OBTAINING SCORE 2 AND WEIGHT 2
            Console.WriteLine("Type the second score");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second score's weight");
            double peso2 = double.Parse(Console.ReadLine());

            //OBTAINING SCORE 3 AND WEIGHT 3
            Console.WriteLine("type the third score");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second score's weight");
            double peso3 = double.Parse(Console.ReadLine());


            //CÁLCULO DA MÉDIA
            Console.WriteLine("The average is : " + (nota1 * peso1 + nota2 * peso2 +  nota3 * peso3) / 3);
        }
    }
}
