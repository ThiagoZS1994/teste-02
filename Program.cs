using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10NúmerosInteirosPositivosSomaPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Valores = new int[11];
            int i, soma=0;

            for (i = 1; i < 11; i++)
            {
                Console.WriteLine("Inserir o valor positivo de n°{0}:", i);
                Valores[i] = int.Parse(Console.ReadLine());

                    if (Valores[i] < 0 )
                    {
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Valor negativo!");
                        Console.ReadKey();
                    }
            }

            for (i=1;i<11;i++)
            {
                if (Valores[i]%2==0)
                {
                    soma = soma + Valores[i];
                }
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Soma: " + soma);
            Console.ReadKey();
        }
        
    }
    
}
