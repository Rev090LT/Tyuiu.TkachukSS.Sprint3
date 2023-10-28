using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint3.Task5.V3.Lib;
namespace Tyuiu.TkachukSS.Sprint3.Task5.V3
{
    class Program
    {        
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Ткачук С. С. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы цикличекой структуры                                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Ткачук Семён Сергеевич | РПСб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение выражения                                            *");            
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5; int startValue1 = 1; int startValue2 = 1; int stopValue1 = 3; int stopValue2 = 11;
            double result = 0;
            
            Console.WriteLine($"Переменная X: {x}");
            Console.WriteLine($"Старт шага 1: {startValue1}");
            Console.WriteLine($"Конец шага 1: {stopValue1}");
            Console.WriteLine($"Старт шага 2: {startValue2}");
            Console.WriteLine($"Конец шага 2: {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"Значение выражения = {result}");
            Console.ReadKey();
        }
    }
}
