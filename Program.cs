using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10NúmerosInteirosPositivosMédiaAritimética
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Valores = new int[11];
            int i, valoresÍmpares=0;
            double soma = 0, media;

            for (i = 1; i < 11; i++)
            {
                Console.WriteLine("Inserir o valor positivo de n°{0}:", i);
                Valores[i] = int.Parse(Console.ReadLine());

                if (Valores[i] < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Valor negativo!");
                    Console.ReadKey();
                }
            }

            for (i = 1; i < 11; i++)
            {
                if (Valores[i] % 2 != 0)
                {
                    soma = soma + Valores[i];
                    valoresÍmpares = valoresÍmpares + 1;
                }
            }

            media = soma / valoresÍmpares;

            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Média aritimética: " + media);
            Console.ReadKey();
        }
    }
}
