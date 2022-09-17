using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dz2_Arick
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = double.Parse(Console.ReadLine());
            PrintAllValues(r);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите x");
                    String user_input = Console.ReadLine();
                    if (user_input == "")//если ничего не ввели,заканчиваем программу
                    {
                        break;
                    }
                    double x = double.Parse(user_input);
                    WhatIsFunction(x, r);
                }
                catch (System.FormatException)//проверка на число
                {
                    Console.WriteLine("Введён некорректный x");
                }
            }
        }
        static double GetYFromFirstSegment(double x)//первый сегмент
        {
            double y = 1;
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }
        static double GetYfromSecondSegment(double x, double R)//второй сегмент
        {   if (R * R - (x + 1) * (x + 1) >= 0)
            {
                double y = -Math.Round(Math.Sqrt(R * R - (x + 1) * (x + 1)), 3);
                Console.WriteLine($"Значение функции при x = {x}: {y}");
                return y;
            }
            else
            {
                if (x ==-3 || x ==-1)// проверка на точки
                {
                    return 0;
                };
                Console.WriteLine($"Функция неопределена при х={x}");
                return 0;
            }
        }

        static double GetYFromThirdSegment(double x)//третий сегмент
        {
            double y = -2;
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static double GetYfromFourthSegment(double x)
        {
            double y = Math.Round((x - 4), 3);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static void WhatIsFunction(double x, double r)
        {
            if (-5 <= x && x <= -3)
            {
                GetYFromFirstSegment(x);
            };
            if (-3 <= x && x <= -1)
            {

                GetYfromSecondSegment(x, r);
            };
            if ((double)-1 <= x && x <= 2)
            {
                GetYFromThirdSegment(x);
            };
            if (2 < x && x <= 5)
            {
                GetYfromFourthSegment(x);
            };
            if (x > 5 || x < -5)
            {
                Console.WriteLine("x должен принадлежать отрезку [-5, 5]");
            };
        }

        static void PrintAllValues(double r)//выдача значений с шагом 0,2
        {
            for (double x = -5; x <= 5; x += (double)0.2)
            {
                WhatIsFunction(Math.Round(x, 2), r);
            }

        }
    }
}