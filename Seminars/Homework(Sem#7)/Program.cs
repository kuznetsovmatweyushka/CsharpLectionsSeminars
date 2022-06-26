/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами. */
/* Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел от: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел до: ");
int b = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(a, b + 1) + new Random().Nextint();
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
}
FillArray(array, a, b);
Console.WriteLine("Ваш массив выглядит вот так: ");
PrintArray(array); */

/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет. */
/* Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел от: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел до: ");
int b = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(a, b + 1);
        }
    }
}
FillArray(array, a, b);
Console.WriteLine("Ваш массив выглядит вот так: ");
PrintArray(array);
Console.WriteLine("Введите номер строки: ");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int n1 = int.Parse(Console.ReadLine());
void FindElement(int[,] array, int m1, int n1)
{
    bool search = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (m1 >= array.GetLength(0) || n1 >= array.GetLength(1))
                search = false;
        }
    }
    if (search == true) Console.WriteLine($"Элемент существует и равен {array[m1, n1]}!");
    else Console.WriteLine("Элемента не существует!");
}
FindElement(array, m1, n1); */

/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце. */
/* Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел от: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел до: ");
int b = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(a, b + 1);
        }
    }
}
FillArray(array, a, b);
Console.WriteLine("Ваш массив выглядит вот так: ");
PrintArray(array);
void Average(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i< array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее арифметическое {j} столбца: {sum / array.GetLength(0)} ");
    }
}
Average(array); */