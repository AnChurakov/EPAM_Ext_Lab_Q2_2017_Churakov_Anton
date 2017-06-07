using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Элемент двумерного массива считается стоящим на чётн
ой позиции, если  сумма  номеров  его  позиций  по  обеим  размерностям  является 
чётным  числом  (например,  [1,1] чётная  позиция,  а  [1,2] нет).  
Определить сумму элементов массива, стоящих на чётных позициях.
     */

namespace Task04
{
    class Program
    {
        static void Main(string[] args)//todo pn  В консоли ничего не понятно.
		{
	        Console.InputEncoding = Encoding.Unicode;
	        Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Определение суммы элементов, укоторых позиция является четной");

			int i, j, sum = 0;
            int[,] mas = new int[10, 10];

            Random rand = new Random();

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    mas[i, j] = rand.Next(10);

                    Console.Write("{0} ", mas[i, j]);

                    if (((i + j ) % 2) == 0)
                    {
                        sum += mas[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма = {0}", sum);

            Console.ReadKey();
        }
    }
}
