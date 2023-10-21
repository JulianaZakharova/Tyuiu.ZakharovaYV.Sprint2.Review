using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint2.Review.V13.Lib;

namespace Tyuiu.ZakharovaYV.Sprint2.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#2 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#2 *");
            Console.WriteLine("* Тема: Итоговое решение по спринту *");
            Console.WriteLine("* Задание #Review *");
            Console.WriteLine("* Вариант #13 *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные *");
            Console.WriteLine("* и вычисляет, находится ли точка в заштрихованной области. *");
            Console.WriteLine("* *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите координату Х: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            y = double.Parse(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) не находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    
    }
}
        
    

