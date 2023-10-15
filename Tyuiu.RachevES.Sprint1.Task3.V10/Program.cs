using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint1.Task3.V10.Lib;

namespace Tyuiu.RachevES.Sprint1.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                           *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                             *");
            Console.WriteLine("* Задание #3                                                                          *");
            Console.WriteLine("* Вариант #10                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,             *");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.                        *");
            Console.WriteLine("*  Написать программу,                                                                *");
            Console.WriteLine("*  которая преобразует введенное с клавиатуры дробное число в денежный формат.        *");
            Console.WriteLine("*  Ответ округлите до 3 знаков после запятой.                                         *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("  23.6 руб. — это 23 руб. 60 коп.                                                     *");
            int x;
            Console.WriteLine("Введите дробное число : ");

            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");

            Console.WriteLine("Это = " + ds.NumberToMoney(x) +"руб");
            Console.ReadLine();
        }
    }
}
