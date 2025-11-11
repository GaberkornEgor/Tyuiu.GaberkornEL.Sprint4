using Tyuiu.GaberkornEL.Sprint4.Task3.V13.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Двумерные массивы(статический ввод)                            *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #13                                                          *");
Console.WriteLine("* Выполнил Габеркорн Егор Леонидович | АСОиУб-25-1                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный     *");
Console.WriteLine("* статическими значениями в диапазоне от 1 до 7.                       *");
Console.WriteLine("* Найдите сумму элементов в третьем столбце массива.                   *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* 4, 7, 4, 2, 1,                                                       *");
Console.WriteLine("* 6, 7, 3, 6, 5,                                                       *");
Console.WriteLine("* 6, 5, 3, 3, 5,                                                       *");
Console.WriteLine("* 4, 4, 6, 4, 7,                                                       *");
Console.WriteLine("* 2, 1, 2, 3, 4,                                                       *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int[,] array = {{4, 7, 4, 2, 1 },{6, 7, 3, 6, 5 }, {6, 5, 3, 3, 5 },{4, 4, 6, 4, 7 },{2, 1, 2, 3, 4 }
};

int sumInFourthColumn = dataService.Calculate(array);

Console.WriteLine($"Минимальный элемент в четвертом столбце: {sumInFourthColumn}");
Console.WriteLine("************************************************************************");
Console.ReadLine();