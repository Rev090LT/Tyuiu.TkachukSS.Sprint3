using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint3.Task4.V23.Lib;

namespace Tyuiu.TkachukSS.Sprint3.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Ткачук С. С | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы цикличекой структуры                                    *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Ткачук Семён Сергеевич | РПСб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                        *");
            Console.WriteLine("* вычислить значение функции y = (cos(x) / x) + 3 *                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5; int stop = 5;
            Console.WriteLine($"Старт шага: {start}");
            Console.WriteLine($"Конец шага: {stop}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Произведение и значение функции = {dataService.Calculate(start, stop)}");
        }
    }
}
