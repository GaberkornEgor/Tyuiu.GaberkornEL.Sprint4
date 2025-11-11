using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GaberkornEL.Sprint4.Task6.V22.Lib;

namespace Tyuiu.GaberkornEL.Sprint4.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Обработка структурных типов                                      *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Снег, Дождь, Туман, Град, Ветер, Туча,     *");
            Console.WriteLine("* Засуха], используя класс Array, выведите элементы массива, длина которых*");
            Console.WriteLine("* равна 4 символам.                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] word = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Элементы массива, длина которых равна 4 символам:");

            string[] result = ds.Calculate(word);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }
    }
}