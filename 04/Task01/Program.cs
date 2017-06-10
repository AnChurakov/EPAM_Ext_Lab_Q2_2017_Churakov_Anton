using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать  программу,  которая  определяет  среднюю  длину  слова  во 
введенной текстовой строке. Учесть, что символы пунктуации на длину слов влиять не должны
     */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

            string str;
           
            Console.WriteLine("Введите строку");

            str = Console.ReadLine();
            char[] CH = str.ToCharArray();


            string[] words = str.Split(new[] { ' ', '!', '?', ':', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);//todo pn говорил использовать стандартные средства класса Char(IsDigit итп).

            int averageLenght = words.Aggregate(0, (count, nextWord) => count += nextWord.Length) / words.Length;

            Console.WriteLine("Средняя длина строки: {0}", averageLenght);
            Console.ReadLine();
        }
    }
}
