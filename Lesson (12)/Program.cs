using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__12_
{
    //Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
    //метод, определяющий длину окружности по заданному радиусу;
    //метод, определяющий площадь круга по заданному радиусу;
    //метод, проверяющий принадлежность точки с координатами(x, y)
    //кругу с радиусом r и координатами центра x0, y0.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circus.LenCirc(90)); //Пимер 
            Console.WriteLine(Circus.SqrCirc(90)); //Пример
            Console.WriteLine(Circus.LocInCircle(3, 0, 0, 4, 2)); //Пример
            Console.ReadKey();
        }
        static class Circus
        {
            public static double LenCirc(double radius)
            {
                return radius / (2 * Math.PI);
            }
            public static double SqrCirc(double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            public static string LocInCircle(double radius, double xDot, double yDot, double xCircle, double yCircle)
            {
                if (Math.Sqrt(Math.Pow(xCircle - xDot, 2) + Math.Pow(yCircle - yDot, 2)) <= radius)
                {
                    string ansver = "Точка принадлежит окружности";
                    return ansver;
                }
                else
                {
                    string ansver = "Точка не принадлежит окружности";
                    return ansver;
                }
            }
        }
    }

}