using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void PrintList(IEnumerable<int> list)
        {
            foreach (var item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var list = new List<int>();

            Console.WriteLine("Введите число n");

            int n = int.Parse(Console.ReadLine());

            for(int j = 1; j <= n; j++)
            {
                list.Add(j);
            }

            PrintList(list);
            bool del = false;

            while (list.Count > 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (del)
                    {
                        list.RemoveAt(i--);
                    }
                    del = !del;
                }
                PrintList(list);
            }
            Console.Read();

            Console.ReadKey();
        }
    }
}
