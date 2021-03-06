﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Дано действительное число h. Выяснить имеет ли уравнение а*а+bx+c=0 действительные корни.
Если корни существуют, найти их. В противном случае ответом должно быть сообщение, что действительных корней нет
*/

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
	        Console.InputEncoding = Encoding.Unicode;
	        Console.OutputEncoding = Encoding.Unicode;

			double h, D, a, x1, x2, b, c;

            Console.WriteLine("Введите число h");
            h = double.Parse(Console.ReadLine());


            a = Math.Sqrt((Math.Abs(Math.Sin(8 * h)) + 17) / (Math.Pow((1 - Math.Sin(4 * h) * Math.Cos(h * h + 18)), 2)));

            b = 1 - (Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a * h * h) - Math.Sin(a * h)))));

            c = a * h * h * Math.Sin(b*h)+b*h*h*h*Math.Cos(a*h);

            D = Math.Truncate(b * b - 4 * a * c);

            Console.WriteLine("a={0} \n b={1} \n c={2} \n Дискриминант = {3}", a, b, c, D);

            if (D>0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1={0} x2={1}", x1, x2);
            }
            else if (D == 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Корень = {0}", x1);
            }
            else
            {
                Console.WriteLine("Корней нет");
            }

            Console.ReadKey();
        }
    }
}
