using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Для  выделения  текстовой  надпи
си  можно  использовать  выделение 
жирным,  курсивом  и  подчёркиванием.  Предложите  способ  хранения 
информации  о  выделении  надписи  и  напишите  программу,  которая 
позволяет назначать и удалять 
текстовой надписи выделение
     */

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string original = "";
            string bold = " Bold";
            string italic = " Italic";
            string underline = " underline";
            bool isNumber = false;
            string str = "Параметры надписи:{0}\n Введите \n 1.Bold\n 2.Italic\n 3.Underline\n";

            Console.WriteLine(str);

            while (!isNumber)
            {
                try
                {
                 

                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        if (original != "")
                        {
                            if (original.Contains(bold))
                            {
                                original = original.Replace(bold, "");
                                Console.WriteLine(str,original);
                            }
                            else
                            {
                                original += bold;
                                Console.WriteLine(str, original);
                            }
                        }
                        else
                        {
                            original = bold;
                            Console.WriteLine(str, original);
                        }
                    }

                    if (n == 2)
                    {
                        if (original != "")
                        {
                            if (original.Contains(italic))
                            {
                                original = original.Replace(italic, "");
                                Console.WriteLine(str, original);
                            }
                            else
                            {
                                original += italic;
                                Console.WriteLine(str, original);
                            }
                        }
                        else
                        {
                            original = italic;
                            Console.WriteLine(str, original);
                        }
                    }

                    if (n == 3)
                    {
                        if (original != "")
                        {
                            if (original.Contains(underline))
                            {
                                original = original.Replace(underline, "");
                                Console.WriteLine(str, original);
                            }
                            else
                            {
                                original += underline;
                                Console.WriteLine(str, original);
                            }
                        }
                        else
                        {
                            original = underline;
                            Console.WriteLine(str, original);
                        }
                    }


                }
                catch
                {
                    Console.WriteLine("Введите число!");
                }
            }

          

            Console.ReadKey();
        }


    }
}
