using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать программу, которая удваивает в первой введенной строки все 
символы, принадлежащие второй введенной строке
     */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string first  = "";
            string second  = "";
            string FinalString = "";
            Console.WriteLine("Введи первую строку");
            first = Console.ReadLine();
            Console.WriteLine("Введи вторую строку");
            second = Console.ReadLine();
            foreach (char ch in first)
                if (!second.Contains(ch))
                    FinalString += ch;
                else
                {
                    FinalString += ch;
                    FinalString += ch;
                }
            Console.WriteLine("Результат = {0}", FinalString);
            Console.ReadKey();
        }
    }
}
