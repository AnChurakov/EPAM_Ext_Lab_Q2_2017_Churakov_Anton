using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Написать программу, которая определяет площадь прямоугольника со 
сторонами a и b. Если пользователь вводит некорректные значения 
(отрицательные,  или  0),  должно  выдаваться  сообщение  об  ошибке. 
Возможность ввода пользователем строки вида «абвгд», или нецелых
чисел игнорировать.
     */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.InputEncoding = Encoding.Unicode;//todo pn просил же добавлять...
	        Console.OutputEncoding = Encoding.Unicode;
			
			int s = 0;
            bool isNumber = false;//todo pn фактически это лишняя переменная. Можно было и на s смотреть.

            Console.WriteLine("Введите число А и Б");

            while (s == 0)
            {
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());

                    if ((a <= 0) || (b <= 0))
                    {
                        Console.WriteLine("Введите положительное число!");
                    }
                    else
                    {
                        isNumber = true;
                        s = b * a;
                    }
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                }
            }

            Console.WriteLine("Площадь прямоугольника = {0}", s);
            Console.ReadKey();
        }
    }
}
