﻿using System;
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
    class Program//todo pn не увидел исследовательской работы.
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
			Console.InputEncoding = Encoding.Unicode;
	        Console.OutputEncoding = Encoding.Unicode;

			CheckString(100);
            CheckString(200);
            CheckString(500);
            CheckString(1000);

            CheckBuilder(100);
            CheckBuilder(200);
            CheckBuilder(500);
            CheckBuilder(1000);

            Console.ReadKey();
        }
    }
}
