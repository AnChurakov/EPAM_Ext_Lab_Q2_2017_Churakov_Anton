﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Если выписать все натуральные числа меньше 10, кратные 3, или 5, то 
получим  3,  5,  6  и  9.  Сумма  этих  чисел  будет  равна  23.  Напишите 
программу, которая выводит на экран сумму всех чисел меньше 1000, 
кратных 3, или 5. 
     */

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, i;
            sum = 0;

            for (i = 1; i < 1000; i++)//todo pn почему всё слиплось?
            { 

                if ((i % 3 == 0) || (i % 5 == 0))//todo pn почему всё слиплось?
				{
                    sum += i;
                }

            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
