using Tyuiu.GaberkornEL.Sprint4.Task5.V7.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.GaberkornEL.Sprint4.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила Габеркорн Егор Леонидович | АСОиУб-25-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                 *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                               *");
            Console.WriteLine("* Задание #4                                                                *");
            Console.WriteLine("* Вариант #7                                                                *");
            Console.WriteLine("* Выполнила: Габеркорн Егор Леонидович | АСОиУб-25-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов                       *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -7 до 7.                 *");
            Console.WriteLine("* Найти количество отрицательных элементов.                                 *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int len;
            Console.WriteLine("Введите размерность массива (5):");
            len = Convert.ToInt32(Console.ReadLine());
            int[,] numsArray = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.WriteLine($"Введите элемент массива [{i + 1},{j + 1}] (от -7 до 7):");
                    numsArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(numsArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int result = ds.Calculate(numsArray);
            Console.WriteLine("Количество отрицательных элементов массива:");
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}