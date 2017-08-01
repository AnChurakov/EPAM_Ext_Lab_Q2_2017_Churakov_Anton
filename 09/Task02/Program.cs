using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите расширяющий метод, который определяет,
//является ли
//строка положительным целым числом.Методы Parse и TryParse не
//использовать


namespace Task02
{
    public static class Test
    {
        public static bool CheckStr(this string str)
        {
            bool itog;
            int i;//todo pn м?

            itog = str.Length == str.Where(c => char.IsDigit(c) && c >= 0).Count(); //todo pn str.Count(c => char.IsDigit(c) && c >= 0) можно сократить

			return itog;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Введите строку");

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            str = Console.ReadLine();

            bool digit = str.CheckStr();

            Console.WriteLine("Является ли строка положительным числом? {0}", digit);

            Console.ReadKey();

        }
    }
}
