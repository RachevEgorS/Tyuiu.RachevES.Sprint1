using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint1.Task2.V24.Lib;

namespace Tyuiu.RachevES.Sprint1.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                           *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                                 *");
            Console.WriteLine("* Задание #2                                                                          *");
            Console.WriteLine("* Вариант #24                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Формулировка задания: Заданы два числа. Вычислить квадрат их разницы.              * ");
            Console.WriteLine("* Что пользователь вводит ? Первое число(целое число),                                *");
            Console.WriteLine("* Второе число(целое число)Что программа печатает на экране ? Квадрат разницы         *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("  (x-y)*(x-y)                                                                         *");
            int x;
            Console.WriteLine("Введите значение x : ");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Введите значение y : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");

            Console.WriteLine("Квадрат разницы = " + ds.CalculateDiffSquare(x, y));
            Console.ReadLine();
        }
    }
}
