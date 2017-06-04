using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать  программу,  которая  генерирует  случайным  образом 
элементы массива (число элементов в массиве и их тип определяются 
разработчиком), определяет для него максимальное и минимальное 
значения, сортирует массив и выводит полученный результат на экран. 
Примечание: LINQ запросы и готовые функции языка (Sort, Max и т.д.) 
использовать в данном задании запрещается
     */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, i, j;
            int[] arr = new int[10];
            int[] mas = new int[10];

            Random r = new Random();

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(15);
                Console.Write("{0} ", arr[i]);
            }

            max = arr[1];
            min = arr[1];

            for (i = 0; i < arr.Length; i++)
            {
                
                if (max < arr[i])
                {
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            int temp;

            for (i=0;i<arr.Length-1;i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine();

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Максимальный элемент = {0} Минимальный = {1}", max, min);

            Console.ReadKey();
        }
    }
}
