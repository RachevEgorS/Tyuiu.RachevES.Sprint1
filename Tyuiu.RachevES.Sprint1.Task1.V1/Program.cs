using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint1.Task1.V1.Lib;

// Написать программу,
// которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле x/3/y+6*a и печатает его на экране

namespace Tyuiu.RachevES.Sprint1.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                           *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                    *");
            Console.WriteLine("* Задание #1                                                                          *");
            Console.WriteLine("* Вариант #1                                                                          *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,             *");
            Console.WriteLine("* вычисляет результат по формуле x/3/y+6*a и печатает его на экране                   *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("  x/3/y+6*a                                                                           *");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");
            double x, y, a;

            Console.WriteLine ("Введите значение X");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.Calculate(x, y, a));
            Console.ReadLine();
        }
    }
}
