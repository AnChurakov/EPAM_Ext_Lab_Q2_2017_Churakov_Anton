using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать  программу,  которая  определяет  сумму  неотрицательных 
элементов в одномерном массиве. Число элементов в массиве и их тип 
определяются разработчиком.
     */

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
	        Console.InputEncoding = Encoding.Unicode;
	        Console.OutputEncoding = Encoding.Unicode;

			int i, sum = 0;
            int[] mas = new int[10];

            Random rand = new Random();

            for (i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-10, 10);
                
                if (mas[i] < 0)
                {
                    sum += mas[i];
                }

                Console.Write("{0} ", mas[i]);
            }

            Console.WriteLine("Сумма = {0}", sum);

            Console.ReadKey();
        }
    }
}
