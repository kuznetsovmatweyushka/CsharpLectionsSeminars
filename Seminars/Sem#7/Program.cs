/* Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами. */
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
PrintArray(array); */

/* Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
Выведите полученный массив на экран.*/
/* Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
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
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
}
FillArray(array);
Console.WriteLine("Ваш массив выглядит вот так: ");
PrintArray(array); */

/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. */
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
void SquareArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 & j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
}
FillArray(array, a, b);
Console.WriteLine("Ваш массив выглядит вот так: ");
PrintArray(array);
SquareArray(array);
Console.WriteLine("Ваш массив выглядит теперь вот так: ");
PrintArray(array);
*/

/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д. */
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
int SummElements(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) count = count + array[i, j];
        }
    }
    return count;
}
FillArray(array, a, b);
Console.WriteLine("Ваш массив выглядит вот так: ");
PrintArray(array);
int summ = SummElements(array);
System.Console.WriteLine($"Сумма элементов на главной диагонали равна: {summ} "); */

