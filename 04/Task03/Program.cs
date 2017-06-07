using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Проведите сравнительный  анализ  скорости  работы  классов String  и 
StringBuilder для операции сложения строк
     */

namespace Task03
{
    class Program
    {
        public static void CheckString(int n)
        {
            string str = "";

            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < n; i++)
            {
                str += "*";
            }
            sw.Stop();
            Console.WriteLine("Результат строки = {0}",sw.Elapsed.TotalMilliseconds);

        }

        public static void CheckBuilder(int n)
        {
            StringBuilder sb = new StringBuilder();

            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < n; i++)
            {
                sb.Append("*");
            }
            sw.Stop();
            
            Console.WriteLine("Результат билдера = {0}",sw.Elapsed.TotalMilliseconds);
        }

        static void Main(string[] args)
        {
            
            CheckString(100);

            CheckBuilder(100);

            Console.ReadKey();
        }
    }
}
