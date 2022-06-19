/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве. */
/* Console.Write("Введите количество эл-в в массиве: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон цифр от: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("до ");
int b = int.Parse(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(a, b + 1);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Ваш массив выглядит так: ");
PrintArray(array);
int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int even = EvenNumbers(array);
Console.WriteLine();
Console.Write("Количество четных элементов: " + even); */

/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях. */
/* Console.Write("Введите количество эл-в в массиве: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон цифр от: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("до ");
int b = int.Parse(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(a, b + 1);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Ваш массив выглядит так: ");
PrintArray(array);
int SumUnEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum+=array[i];
        }
    }
    return sum;
}
int sumuneven = SumUnEven(array);
Console.WriteLine();
Console.Write("Количество четных элементов: " + sumuneven); */

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */
/* Console.Write("Введите количество эл-в в массиве: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон цифр от: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("до ");
int b = int.Parse(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(a, b + 1);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Ваш массив выглядит так: ");
PrintArray(array);
int Max(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
int min = Min(array);
int max = Max(array);
int difference = max - min;
Console.WriteLine();
Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Разница между максимальным и минимальным элементом: " + difference); */