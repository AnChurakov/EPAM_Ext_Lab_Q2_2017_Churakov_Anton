using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написать  класс  User,  описывающий  человека  (Фамилия,  Имя, 
Отчество,   Дата   рождения,   Возраст).   Написать   програ
мму, демонстрирующую использование этого класса
     */

namespace Task03
{
    class Man
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Patronymic { get; set; }
        int Age { get; set; }
        DateTime BirthDate { get; set; }

        public Man(string Firstname, string Lastname, string Patronymic, int Age, DateTime BirthDate)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Patronymic = Patronymic;
            this.Age = Age;//todo pn т.е. ты задаешь и возраст и дату рождения? Серьезно? Мб, сделать её вычисляемой из даты рождения?
            this.BirthDate = BirthDate;
        }

        public string GetFirstname()
        {
            return Firstname;
        }

        public string GetLastname()
        {
            return Lastname;
        }

        public string GetPatronymic()
        {
            return Patronymic;
        }

        public int GetAge()
        {
            return Age;
        }

        public DateTime GetBirthDate()
        {
            return BirthDate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string Firstname = "", Lastname = "", Patronymic = "", BirthDate = "";
            string[] ParseBirthDate;
            int Age = 0, RealAge;
            DateTime date = DateTime.Now;  
            
            while (Age <= 0 )
            {
                try
                {
                    Console.WriteLine("Введите фамилию");
                    Lastname = Console.ReadLine();

                    Console.WriteLine("Введите имя");
                    Firstname = Console.ReadLine();

                    Console.WriteLine("Введите отчество");
                    Patronymic = Console.ReadLine();

                    Console.WriteLine("Введите возраст");
                    Age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите дату рождения в формате День.Месяц.Год (01.01.1999)");
                    BirthDate = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Введите корректные данные!");
                }
            }
            

            ParseBirthDate = BirthDate.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int day = Convert.ToInt32(ParseBirthDate[0]);
            int month = Convert.ToInt32(ParseBirthDate[1]);
            int year = Convert.ToInt32(ParseBirthDate[2]);
      
            DateTime MyBirthDate = new DateTime(year, month, day);

            RealAge = date.Year - MyBirthDate.Year;

            if (RealAge != Age)
            {
                Age = RealAge;
            }

            Man man = new Man(Firstname, Lastname, Patronymic, Age, MyBirthDate);

            Console.WriteLine("Имя = {0}\nФамилия = {1}\nОтчество = {2}\nВозраст = {3}\nДата рождения = {4}", man.GetFirstname(), man.GetLastname(), man.GetPatronymic(), man.GetAge(), man.GetBirthDate());

            Console.ReadKey();

        }
    }
}
