using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AvaevaPD.Sprint1.Task5.V0.Lib;

//ЗАДАНИЕ
//Найти частное между квадратом X и его корнем. Ответ привести к целому с помощью класса Convert.

namespace Tyuiu.AvaevaPD.Sprint1.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Авaева П. Д. | ИСПБ-23-1";
            // Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование классов тип Convert                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнила: Аваева Полина Дмитриевна | ИСПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти частное между квадратом X и его корнем.                           *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x));
            Console.WriteLine(res);

            Console.ReadKey();


        }
    }
}
