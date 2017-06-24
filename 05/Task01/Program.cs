using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать  класс  Round,  задающий  круг  с  указанными  координатами 
центра, радиусом, а также свойствами, 
позволяющими узнать длину описанной  окружности  и  площадь  круга.  Обеспечить  нахождение 
объекта  в  заведомо  корректном  состоянии.  Написать  программу, 
демонстрирующую использование данного круга
.
     */

namespace Task01
{
    class Round
    {
        int x { get; set; }
        int y { get; set; }
        int radius { get; set; }
        
        public Round(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            radius = r;//todo pn а если задали отрицательный радиус? нужна проверка
        }

        public double Area()
        {
            double S = Math.PI * Math.Pow(radius, 2);
            return S;
        }

        public double Length()
        {
            double dl = 2 * Math.PI * radius;
            return dl;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int x = 0, y = 0, r = -1;

            while (r < 0)
            {
                try
                {
                    Console.WriteLine("Введите X");

                    x = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите Y");

                    y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите радиус");

                    r = int.Parse(Console.ReadLine());

                    if (r < 0)
                    {
                        Console.WriteLine("Введите положительный радиус!");
                        
                    }
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                }
            }

        

            Round round = new Round(x, y, r);

            Console.WriteLine("Площадь круга = {0}\nДлина окружности = {1}", round.Area(), round.Length());

            Console.ReadKey();

        }
    }
}
