using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint1.Task7.V8.Lib;

namespace Tyuiu.KugaevskijSD.Sprint1.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #1                                                               -");
            Console.WriteLine("- Тема: Базовые навыки работы C#                                          -");
            Console.WriteLine("- Задание #7                                                              -");
            Console.WriteLine("- Вариант #8                                                              -");
            Console.WriteLine("- Выполнил: Кугаевский Сергей Дмитриевич | АСОиУб-25-1                    -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                -");
            Console.WriteLine("- Написать программу, которая вычисляет математическое выражение по       -");
            Console.WriteLine("- исходным значениям данных, вводимых пользователем. Ответ округлите до 3 -");
            Console.WriteLine("- знаков после запятой.                                                   -");
            Console.WriteLine("-                    y                                                    -");
            Console.WriteLine("-   z = x ln x + ----------                                               -");
            Console.WriteLine("-                    x                                                    -");
            Console.WriteLine("-             cos x - -                                                   -");
            Console.WriteLine("-                    3                                                    -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("Введите значение X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите значение Y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");



            var result = ds.Calculate(x, y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}