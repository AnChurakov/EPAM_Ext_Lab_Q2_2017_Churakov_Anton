using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {

            String str = "";

            int i;          

            Console.WriteLine("Введите текст на английском");

            str = Console.ReadLine();

            str = str.ToLower();

            string[] split = str.Split(' ', ',');

            List<string> list = new List<string>();

            list.Add(str);

            foreach(var s in list)
            {
                if(s.Contains(s))
                {
                    list.Add()
                }
            }
         
            Console.ReadKey();
        }
    }
}
