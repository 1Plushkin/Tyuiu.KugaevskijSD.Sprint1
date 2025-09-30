using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint1.Task6.V9.Lib;

namespace Tyuiu.KugaevskijSD.Sprint1.Task6.V9
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
            Console.WriteLine("- Задание #6                                                              -");
            Console.WriteLine("- Вариант #9                                                              -");
            Console.WriteLine("- Выполнил: Кугаевский Сергей Дмитриевич | АСОиУб-25-1                    -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                -");
            Console.WriteLine("- Написать программу: пользователь вводит текст. Напечатать все слова,    -");
            Console.WriteLine("- перенеся их последнюю букву в начало.                                   -");
            Console.WriteLine("-                                                                         -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
            Console.WriteLine("- Известно расстояние в метрах. Вычислить расстояние в дюймах.            -");
            Console.WriteLine("- Ответ округлите до 3 знаков после запятой.                              -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");

            String value = "";


            Console.WriteLine("Введите слова");
            value = Convert.ToString(Console.ReadLine());



            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");


            Console.WriteLine(ds.MoveLetterToStart(value));

            Console.ReadLine();
        }
    }
}