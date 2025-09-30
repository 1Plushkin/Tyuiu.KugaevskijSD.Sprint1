using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint1.Task2.V25.Lib;

namespace Tyuiu.KugaevskijSD.Sprint1.Task2.V25
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
            Console.WriteLine("- Задание #0                                                              -");
            Console.WriteLine("- Вариант #29                                                             -");
            Console.WriteLine("- Выполнил: Кугаевский Сергей Дмитриевич | АСОиУб-25-1                    -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                -");
            Console.WriteLine("- Написать программу, которая запрашивает у пользователя угол в радианах,         -");
            Console.WriteLine("- переводит угол в градусы и результат печатает его на экране.                                        -");
            Console.WriteLine("-                                                                         -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine(" 2 * 9 + 7 * 2                                                            -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");
            
            
            int x;

            Console.WriteLine("Введите величину угла в радианах:");
            x = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine(ds.ConvertRadsToDegrees(x));

            Console.ReadLine();
        }
    }
}