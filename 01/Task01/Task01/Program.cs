using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Пользователь вводит координаты точки X и Y и выбирает букву графика. В консоли должно высветиться 
 Сообщение: точка X;Y принадлежит фигуре ...
     */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;

            Console.WriteLine("Введите координаты точки x и y");

            x = float.Parse(Console.ReadLine());

            y = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите букву графика (а-к)");
            
            string str = Console.ReadLine();

            if (str == "а")
            {
                int radius = 1;

                if ((x <= 1) && (x >= 0) && (y <= 1) && (y >= 0) && (x * x + y * y <= 1))
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);
                }
            }

            if (str == "б")
            {
                if (((x >= 0.5) && (x <= 1) && (y >= 0.5) && (y <= 1) && (x * x + y * y <= 1)) || ((x >= -1) && (x <= -0.5) && (y >= 0.5) && (y <= 1) && (x * x + y * y <= 1)) ||
                        ((x >= -1) && (x <= -0.5) && (y >= -0.5) && (y <= -1) && (x * x + y * y <= -1)) || ((x >= 0.5) && (x <= 1) && (y <= -0.5) && (y >= -1)))
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);
                }
            }

            if (str == "в")
            {
                if (((x <= 1) && (x >= 0) && (y <= 1) && (y >= 0)) || ((x >= -1) && (x <= 0) && (y <= 1) && (y >= 0))
                        || ((x >= -1) && (x <= 0) && (y >= -1) && (y <= 0)) || (x >= 0) && (x <= 1) && (y >= -1) && (y <= 0))
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);

                }

            }

            if (str == "г")
            {
                if (((x <= 1) && (x >= 0) && (y <= 1) && (y >= 0) && (y <= -x + 1)) || ((x >= -1) && (x <= 0) && (y <= 1) && (y >= 0) && (y <= x + 1)) ||
                    ((x >= -1) && (x <= 0) && (y >= -1) && (y <= 0) && (y <= -x - 1)) || ((x <= 1) && (x >= 0) && (y >= -1) && (y <= 0) && (y <= x - 1))
                    )
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);
                }

            }

            if (str == "д")
            {
                if (((x <= 0.5) && (x >= 0) && (y <= 1) && (y >= 0) && (y <= -x + 1)) || ((x >= -0.5) && (x <= 0) && (y <= 1) && (y >= 0) && (y <= x + 1)) ||
                    ((x >= -0.5) && (x <= 0) && (y >= -1) && (y <= 0) && (y <= -x - 1)) || ((x <= 0.5) && (x >= 0) && (y >= -1) && (y <= 0) && (y <= x - 1))
                    )
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);
                }

            }

            if (str == "е")
            {
                if (((y <= 1) && (y >= 0) && (x >= -2) && (x <= 0) && (y <= x + 2)) || ((y >= -1) && (y <= 0) && (x >= -2) && (x <= 0) && (y <= -x - 2)) ||
                        ((x <= 1) && (x >= 0) && (y <= -1) && (y >= 0) && (x * x + y * y <= 1)) || ((y <= 1) && (y >= 0) && (x <= 1) && (x >= 0) && (x * x + y * y <= 1)))
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);
                }
            }

            if (str == "ж")
            {
                if (((y <= 2) && (y >= 0) && (x >= -1) && (x <= 0) && (y <= 2 * x + 2)) || ((y >= -1) && (y <= 0) && (x >= -1) && (x <= 0) && (y <= 2 * x + 2)) ||
                        ((y <= 2) && (y >= 0) && (x <= 1) && (x >= 0) && (y <= -2 * x + 2)) || ((x <= 1) && (x >= 0) && (y >= -1) && (y <= 0) && (y <= -2 * x + 2)))
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);
                }
            }

            if (str == "з")
            {
                if (((x <= 1) && (x >= 0) && (y <= Math.Abs(x))) || ((x >= -1) && (x <= 0) && (y <= Math.Abs(x))) || ((x >= -1) && (x <= 0) && (y >= -2) && (y <= 0)) || ((x <= 1) && (x >= 0) && (y >= -2) && (y <= 0)))
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);
                }
            }

            if (str == "к")
            {
                if ((y>=Math.Abs(x)) && (y>=0) && (x>=1) || (x<=-1))
                {
                    Console.WriteLine("Точка x={0} y={1} принадлежит фигуре {2}!", x, y, str);
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит фигуре {0}!", str);
                }

                Console.ReadKey();
            }
        }
    }
}
