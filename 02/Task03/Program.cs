using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать программу, которая запрашивает с клавиатуры число N и 
выводит на экран следующее «изображение», состоящее из N строк: 
     */

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, N = 0;

            Console.WriteLine("Введите число N");

            while (N <= 0)
            {
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());

                    if (N < 0)
                    {
                        Console.WriteLine("Введите положительное число!");
                    }
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                }
            }
                
			for (i = N; i != 0; i--)
            {
                for (j = i; j != 0; j--)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (m = (N - i) * 2; m != 0; m--)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
