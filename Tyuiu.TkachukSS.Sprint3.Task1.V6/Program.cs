using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint3.Task1.V6.Lib;

namespace Tyuiu.TkachukSS.Sprint3.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Ткачук С. С. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы цикличекой структуры                                    *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Ткачук Семён Сергеевич | РПСб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле, при a=4                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 4, startValue = 1, stopValue = 10;
            Console.WriteLine($"Переменная X: {value}");
            Console.WriteLine($"Старт шага: {startValue}");
            Console.WriteLine($"Конец шага: {stopValue}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Сумма ряда = {dataService.GetSumSeries(value, startValue, stopValue)}");

            Console.ReadKey();
        }
    }
}
