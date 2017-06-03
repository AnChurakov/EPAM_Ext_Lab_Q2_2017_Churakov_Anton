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
            int i, j, m;

            Console.WriteLine("Введите число N");

            int N = int.Parse(Console.ReadLine());
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
