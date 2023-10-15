using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint1.Task4.V30.Lib;

namespace Tyuiu.RachevES.Sprint1.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                           *");
            Console.WriteLine("* Тема: Class Math                                                                    *");
            Console.WriteLine("* Задание #4                                                                          *");
            Console.WriteLine("* Вариант #30                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,            * ");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                            *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                          *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("  (x+y^3)/(e^2−y)                                                                         *");
            int x;
            Console.WriteLine("Введите значение x : ");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Введите значение y : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");

            Console.WriteLine("((x + Math.Pow(y, 3)) / (Math.Pow(e, 2 - y))) = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
