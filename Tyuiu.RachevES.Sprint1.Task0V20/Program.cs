using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RachevES.Sprint1.Task0.V20.Lib;

namespace Tyuiu.RachevES.Sprint1.Task0V20
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
            Console.WriteLine("* Задание #0                                                                          *");
            Console.WriteLine("* Вариант #20                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 10+9/3                              *");
            Console.WriteLine("* и печатает результат на экране.                                                     *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("  10+9/3                                                                              *");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");
            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
