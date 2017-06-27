using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        delegate List<string> CheckStr(List<string> str);

        static List<string> s(List<string> str)
        {
            str.Sort();
            return str;
        }
        
        static void show(List<string> str)
        {
            foreach (var s in str)
            {
                Console.WriteLine(s);
            }

        }


        static void Main(string[] args)
        {
            string str;
            int i = 0;
            bool check = true;
            List<string> mas = new List<string>();

            Console.WriteLine("Введите строку. Чтобы прекратить ввод, добавть пустую строку");

            while (check)
            {
                str = Console.ReadLine();
                mas.Add(str);

                if (str == "")
                {
                    check = false;
                }
            }

           

            CheckStr st = new CheckStr(s);

            st.Invoke(mas);

            show(mas);

            Console.ReadKey();

        }
    }
}
