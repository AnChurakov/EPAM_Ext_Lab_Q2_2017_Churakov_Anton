using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать класс  Ring(кольцо),  описываемое координатами  центра, 
//внешним и
//внутренним радиусами, а также свойствами, позволяющими
//узнать площадь  кольца и  суммарную длину  внешней и  внутренней
//границ кольца.Обеспечить нахождение класса в заведомо корректном
//состоянии


namespace Task02
{
    class Round
    {
        int x { get; set; }
        int y { get; set; }
        int radius { get; set; } // радиус круга и внутренний радиус

        public Round(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            radius = r;
        }

        public int GetRadius()
        {
            return radius;
        }

        public double Area()
        {
            double S = Math.PI * Math.Pow(radius, 2);
            return S;
        }

        public double Length(int radiusRound) //длина круга
        {
            double dl = 2 * Math.PI * radiusRound;
            return dl;
        }


    }

    class Ring : Round
    {
     
        int R { get; set; } // внешний радиус

        public Ring(int x, int y, int r, int R) : base(x, y, r) 
        {
            this.R = R;
        }

        public double GetAreaRing()//площадь кольца
        {
            double S = Math.Abs(Math.PI * (Math.Pow(R, 2) - Math.Pow(GetRadius(), 2)));
            return S;
        }

        public double GetSumLength(int r, int R)
        {
            double Sum = Length(r) + Length(R);
            return Sum;
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int x = 0, y = 0, r = -1, R = 0;

            while (r < 0)
            {
                try
                {
                    Console.WriteLine("Введите Х");
                    x = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите Y");
                    y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите внутренний радиус");
                    r = int.Parse(Console.ReadLine());

                    if (r < 0)
                    {
                        Console.WriteLine("Введите положительное число!");
                        r = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Введите внешний радиус");
                    R = int.Parse(Console.ReadLine());

                    if (R < 0)
                    {
                        Console.WriteLine("Введите положительное число!");
                        R = int.Parse(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("Введите корректные данные!");
                }

            }

            Ring ob = new Ring(x, y, r, R);

            Console.WriteLine("Площадь кольца = {0}\nСуммарная длина окружностей = {1}", ob.GetAreaRing(), ob.GetSumLength(r, R));

            Console.ReadKey();
        }
    }
}
