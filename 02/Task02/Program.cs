﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать  программу,  которая  запрашивает  с  клавиатуры  число  N  и 
выводит на экран следующее «изображение», состоящее из N строк: 
     */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, n = 0;
            string num = "*";
            int d = 1;

            Console.WriteLine("Введите число N");

            while (n <= 0)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n < 0)
                    {
                        Console.WriteLine("Введите положительое число!");
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                }
            }
            
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < d; j++)
                {
                    Console.Write(num);
                }

                d++;

                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
