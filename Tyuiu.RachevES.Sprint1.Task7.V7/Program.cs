using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint1.Task7.V7.Lib;


namespace Tyuiu.RachevES.Sprint1.Task7.V7
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
            Console.WriteLine("* Задание #7                                                                          *");
            Console.WriteLine("* Вариант #7                                                                          *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                     * ");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                               *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                          *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("                                                                          *");
            double x;
            Console.WriteLine("Введите значение x : ");
            x = Convert.ToInt32(Console.ReadLine());

            double y;
            Console.WriteLine("Введите значение y : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");
            Console.WriteLine("***************************************************************************************");

            Console.WriteLine("((Math.Cos(x)) / (p - 2 * Math.Pow(y,x)) + 16 * x * Math.Cos(x*y) - 2) = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
