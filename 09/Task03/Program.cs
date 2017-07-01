using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public static class Test
    {
        public static int SearchElem (this List<int> mas)
        {
            int s = 0;
       
            foreach (var t in mas)
            {
                if (t > 0)
                {
                    s++;
                }
            }

            return s;
        }

        public static int linq(List<int> mas)
        {
            var lst = from item in mas where item > 0 select item;

            int sum = 0;

            foreach (var s in lst)
            {
                sum++;
            }

            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> mas = new List<int>();
            int i = 0;
            int digit;

            Console.WriteLine("Введите 10 чисел");

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            while (i < 10)
            {
                digit = int.Parse(Console.ReadLine());
                mas.Add(digit);
                i++;
            }

            int digit_second = mas.SearchElem(); //количество положительных элементов в массиве

            Console.WriteLine("Количество положительных элементов в массиве = {0}", digit_second );

            Console.WriteLine("LINQ = {0}", Test.linq(mas));

            Console.ReadKey();

        }
    }
}
