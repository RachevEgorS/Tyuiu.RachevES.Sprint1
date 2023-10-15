using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint1.Task6.V11.Lib;

namespace Tyuiu.RachevES.Sprint1.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                           *");
            Console.WriteLine("* Тема: Работа со строками класса String                                              *");
            Console.WriteLine("* Задание #6                                                                          *");
            Console.WriteLine("* Вариант #11                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                                     * ");
            Console.WriteLine("* Проверить, что первая буква строки входит в нее еще раз.                            *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("                                                                                      *");
           
            Console.WriteLine("Введите слово/предложение : ");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");
            Console.WriteLine("***************************************************************************************");
            bool res = ds.CheckeFirstLetterRepetition(value);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
