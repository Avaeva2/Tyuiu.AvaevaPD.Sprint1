using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AvaevaPD.Sprint1.Task7.V2.Lib;


// Написать программу, которая вычисляет математическое выражение по исходным значениям данных, 
// вводимых пользователем.
//        sin x + cos y 
// z =   -------------- tg xy
//        cos x - sin y


namespace Tyuiu.AvaevaPD.Sprint1.Task7.V2


{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Лабораторная работа №1 | Выполнила: Аваева П. Д. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*      sin x + cos y                                                      *");
            Console.WriteLine("* z = --------------- td xy                                               *");
            Console.WriteLine("*      cos x - sin y                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");


            double x, y, z;

            Console.WriteLine("Введите значение переменной x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y: ");
            y = Convert.ToDouble(Console.ReadLine());
            z = ((Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ 1:                                                            *");
            Console.WriteLine("Значение выражения равно: " + Math.Round(z, 3));
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
