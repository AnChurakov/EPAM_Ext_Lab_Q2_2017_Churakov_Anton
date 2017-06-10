using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать  класс,  описывающий  треугольник  со  сторонами 
a,  b,  c,  и позволяющий осуществить расчёт его площади и периметра. Написать 
программу, демонстрирующую использование данного треугольника
     */

namespace Task02
{
    class Triangle
    {
        int a { get; set; }
        int b { get; set; }
        int c { get; set; }
        
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Perimetr()
        {
            int per = a + b + c;
            return per;
        }

        public int PolyPerim()
        {
            int poly = (a + b + c) / 2;
            return poly;
        }

        public double Area()
        {
            double P = PolyPerim();
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int a = 0, b = 0, c = 0;
            bool Check = false;
            
            Console.WriteLine("Введите стороны треугольника A, B, C");

            while (Check == false)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());

                    b = Convert.ToInt32(Console.ReadLine());

                    c = Convert.ToInt32(Console.ReadLine());

                    if (b < 0 || a < 0 || c < 0)
                    {
                        Console.WriteLine("Введите положительные числа!");
                    }
                    else
                    {
                        Check = true;
                        
                    }
                  
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                }
            }
           

            Triangle tr = new Triangle(a, b, c);

            Console.WriteLine("Периметр = {0}\nПолупериметр = {1}\nПлощадь = {2} ", tr.Perimetr(), tr.PolyPerim() ,tr.Area());

            Console.ReadKey();

        }
    }
}
