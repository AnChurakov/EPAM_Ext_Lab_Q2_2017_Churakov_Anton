using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите расширяющий метод, который определяет сумму элементов
//массива


namespace Task01
{

    public static class Test
    {
        public static int SumMas(this List<int> mas)
        {
            int Sum = 0;

            foreach (var s in mas)
            {
                Sum += s;
            }

            return Sum;
        }
    }


    class Program
    {
      
        static void Main(string[] args)
        {
            int i = 0;
            int digit;
            List<int> mas = new List<int>();

            Console.WriteLine("Введите 10 чисел");

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            while (i < 10)
            {
                digit = int.Parse(Console.ReadLine());
                mas.Add(digit);
                i++;
            }


            int itog = mas.SumMas();

            Console.WriteLine("Сумма элементов массива = {0}", itog);

            Console.ReadKey();

        }
    }
}
