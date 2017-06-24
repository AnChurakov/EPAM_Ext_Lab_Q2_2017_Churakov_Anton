using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//На основе класса User(см.задание 3 из предыдущей темы), создать
//класс  Employee, 
//описывающий сотрудника  фирмы.В дополнение  к
//полям  пользователя добавить  поля  «стаж работы»  и  «должность». 
//Обеспечить нахождение класса в заведомо корректном состоянии

namespace Task01
{

    class User//todo pn в отдельный файл
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Patronymic { get; set; }
        int Age { get; set; }
        DateTime BirthDate { get; set; }

        public User(string Firstname, string Lastname, string Patronymic, int Age, DateTime BirthDate)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Patronymic = Patronymic;
            this.Age = Age;//todo pn т.е. возраст и дата рождения - независящие друг от друга характеристики?
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

    class Employee : User//todo pn в отдельный файл
	{
        string Position { get; set; }
        string WorkExp { get; set; }

        public Employee(string Firstname, string Lastname, string Patronymic, int Age, DateTime BirthDate, string Position, string WorkExp) 
            : base(Firstname, Lastname, Patronymic, Age, BirthDate)
        {
            this.Position = Position;
            this.WorkExp = WorkExp;//todo pn где проверка на то, что меньше возраста?
		}

        public string GetPostion()
        {
            return Position;
        }
        
        public string GetWorkExp()
        {
            return WorkExp;
        }
    }

    class Program//todo pn в отдельный файл
	{
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string Firstname = "", Lastname = "", Patronymic = "", BirthDate = "", WorkExp = "", Position = "";
            string[] ParseBirthDate;
            int Age = 0, RealAge;
            DateTime date = DateTime.Now;

            while (Age <= 0)
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

                    Console.WriteLine("Введите должность)");
                    Position = Console.ReadLine();

                    Console.WriteLine("Введите стаж работу");
                    WorkExp = Console.ReadLine();
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

            Employee man = new Employee(Firstname, Lastname, Patronymic, Age, MyBirthDate, Position, WorkExp);

            Console.WriteLine("Имя = {0}\nФамилия = {1}\nОтчество = {2}\nВозраст = {3}\nДата рождения = {4}\nДолжность = {5}\nСтаж работы = {6}", man.GetFirstname(), man.GetLastname(), man.GetPatronymic(), man.GetAge(), man.GetBirthDate(), man.GetPostion(), man.GetWorkExp());

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
