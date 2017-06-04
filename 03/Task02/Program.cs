using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать программу, которая заменяет все положительные элементы 
в трёхмерном массиве на нули. Число элементов в массиве и их тип 
определяются разработчиком
     */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, k;
            int[,,] mas = new int[10,10,10];

            Random r = new Random();

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    for (k = 0; k < 10; k++)
                    {
                        mas[i, j, k] = r.Next(-10, 10);

                        if (mas[i,j,k] > 0)
                        {
                            mas[i, j, k] = 0;
                        }

                        Console.Write("{0}\t", mas[i, j, k]);
                    }
                    
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
