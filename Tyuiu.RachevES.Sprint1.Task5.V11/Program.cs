using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint1.Task5.V11.Lib;

namespace Tyuiu.RachevES.Sprint1.Task5.V11
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
            Console.WriteLine("* Задание #5                                                                          *");
            Console.WriteLine("* Вариант #3                                                                          *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                               * ");
            Console.WriteLine("* Присвоить целой переменной h третью от конца цифру в записи                         *");
            Console.WriteLine("* положительного целого числа k(например, если k = 130985, то h = 9).                 *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("  ( k / 100) % 10                                                                         *");
            int k;
            Console.WriteLine("Введите значение k : ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");

            Console.WriteLine("третья от КОНЦА цифра = " + ds.Calculate(k));
            Console.ReadKey();
        }
    }
}
