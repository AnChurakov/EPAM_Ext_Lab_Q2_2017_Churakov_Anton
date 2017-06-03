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
    class Program //todo pn в папке с заданием у тебя аж 3 солюшена. Переделай на 1 солюшн с двумя проектами внутри. Лишние солюшены удали.
	{
        static void Main(string[] args)
        {
	        Console.InputEncoding = Encoding.Unicode;//todo pn без явного задания кодировки будет использована кодировка по умолчанию. Машина, на которой я проверяю настроена на английскую культуру, поэтому кириллические символы отображаются в ней как знаки вопроса. Следует учитывать такое специфичное поведение консоли в следующих заданиях :)
	        Console.OutputEncoding = Encoding.Unicode;

			float x, y;
            char str;
            string success = "Точка x={0} y={1} принадлежит фигуре {2}!";
            string fail = "Точка не принадлежит фигуре {0}!";

            Console.WriteLine("Введите координаты точки x и y");

            x = float.Parse(Console.ReadLine());

            y = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите букву графика (а-к)");//todo pn если пользователь вводит недопустимый символ консоль закрывается. А не должна. Нужно просить повторить ввод (неуважение к пользователю все дела ;)

            str = Console.ReadKey().KeyChar;

            if (str == 'а')
            {

                if ((x <= 1) && (x >= 0) && (y <= 1) && (y >= 0) && ((x * x) + (y * y) <= 1))
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);//todo pn очень много повторяющегося кода сообщений. Выдели глобальную переменную на это или константу
                }
            }

            /*
            if (str == "б")
            {
                if (((x >= 0.5) && (x <= 1) && (y >= 0.5) && (y <= 1) && ((x * x) + (y * y) <= 1)) || ((x >= -1) && (x <= -0.5) && (y >= 0.5) && (y <= 1) && ((x * x) + (y * y) <= 1)) ||
                        ((x >= -1) && (x <= -0.5) && (y >= -0.5) && (y <= -1) && ((x * x) + (y * y) <= -1)) || ((x >= 0.5) && (x <= 1) && (y <= -0.5) && (y >= -1)))
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);
                }
            }

            if (str == "в")
            {
                if (((x <= 1) && (x >= 0) && (y <= 1) && (y >= 0)) || ((x >= -1) && (x <= 0) && (y <= 1) && (y >= 0))
                        || ((x >= -1) && (x <= 0) && (y >= -1) && (y <= 0)) || ((x >= 0) && (x <= 1) && (y >= -1) && (y <= 0)))
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);
                }
            }

            if (str == "г")
            {
                if (((x <= 1) && (x >= 0) && (y <= 1) && (y >= 0) && (y <= -x + 1)) || ((x >= -1) && (x <= 0) && (y <= 1) && (y >= 0) && (y <= x + 1)) ||
                    ((x >= -1) && (x <= 0) && (y >= -1) && (y <= 0) && (y <= -x - 1)) || ((x <= 1) && (x >= 0) && (y >= -1) && (y <= 0) && (y <= x - 1))
                    )
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);
                }
            }

            if (str == "д")
            {
                if (((x <= 0.5) && (x >= 0) && (y <= 1) && (y >= 0) && (y <= -x + 1)) || ((x >= -0.5) && (x <= 0) && (y <= 1) && (y >= 0) && (y <= x + 1)) ||
                    ((x >= -0.5) && (x <= 0) && (y >= -1) && (y <= 0) && (y <= -x - 1)) || ((x <= 0.5) && (x >= 0) && (y >= -1) && (y <= 0) && (y <= x - 1))
                    )
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);
                }

            }

            if (str == "е")
            {
                if (((y <= 1) && (y >= 0) && (x >= -2) && (x <= 0) && (y <= x + 2)) || ((y >= -1) && (y <= 0) && (x >= -2) && (x <= 0) && (y <= -x - 2)) ||
                        ((x <= 1) && (x >= 0) && (y <= -1) && (y >= 0) && ((x * x) + (y * y) <= 1)) || ((y <= 1) && (y >= 0) && (x <= 1) && (x >= 0) && ((x * x) + (y * y) <= 1)))
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);
                }
            }

            if (str == "ж")
            {
                if (((y <= 2) && (y >= 0) && (x >= -1) && (x <= 0) && (y <= (2 * x) + 2)) || ((y >= -1) && (y <= 0) && (x >= -1) && (x <= 0) && (y <= (2 * x) + 2)) ||
                        ((y <= 2) && (y >= 0) && (x <= 1) && (x >= 0) && (y <= (-2 * x) + 2)) || ((x <= 1) && (x >= 0) && (y >= -1) && (y <= 0) && (y <= (-2 * x) + 2)))
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);
                }
            }

            if (str == "з")
            {
                if (((x <= 1) && (x >= 0) && (y <= Math.Abs(x))) || ((x >= -1) && (x <= 0) && (y <= Math.Abs(x))) || ((x >= -1) && (x <= 0) && (y >= -2) && (y <= 0)) || ((x <= 1) && (x >= 0) && (y >= -2) && (y <= 0)))
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);
                }
            }

			//todo pn а где "и"?

            if (str == "к")
            {
                if ((y>=Math.Abs(x)) && (y>=0) && (x>=1) || (x<=-1))
                {
                    Console.WriteLine(success, x, y, str);
                }
                else
                {
                    Console.WriteLine(fail, str);
                }
                
                Console.ReadKey();
            }
            */
            Console.ReadKey();
        }
    }
}
