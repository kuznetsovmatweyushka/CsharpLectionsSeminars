/* Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */
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
int MinSum(int[] array)
{
    int MinSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            MinSum += array[i];
        }
    }
    return MinSum;
}
int negative = MinSum(array);
int MaxSum(int[] array)
{
    int MaxSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            MaxSum += array[i];
        }
    }
    return MaxSum;
}
int positive = MaxSum(array);
Console.WriteLine();
Console.WriteLine("Cумма отрицательных элементов равна: " + negative);
Console.WriteLine("Cумма положительных элементов равна: " + positive); */

/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот. */
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
Console.WriteLine("Оригинальный массив: ");
PrintArray(array);
Console.WriteLine();
void ReplaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] * -1 + " ");
    }
}
Console.WriteLine("Замененный массив: ");
ReplaseArray(array); */

/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве. */
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
System.Console.WriteLine();
Console.Write("Введите число наличие которого вы хотите проверить: ");
int find = int.Parse(Console.ReadLine());
void FindChar(int[] array, int find)
{
    bool answer = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            answer = true;
            break;
        }
    }
    if (answer == true)
    {
        System.Console.WriteLine("Число присутствует!");
    }
    else System.Console.WriteLine("Число отсутствует");
}
FindChar(array, find); */

/* Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].  */
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
System.Console.WriteLine();
Console.Write("Введите начало отрезка: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец отрезка: ");
int end = int.Parse(Console.ReadLine());
int FindVolume(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (start <= array[i] & array[i] <= end)
        {
            count++;
        }
    }
    return count;
}
int volume = FindVolume(array, start, end);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [{start},{end}]: " + volume); */

/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. */
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

void PrintComposition(int[] array)
{
    int[] composition = new int[(array.Length + 1) / 2];
    for (int i = 0; i < composition.Length; i++)
    {
        array[i] = array[i] * array[array.Length - i - 1];
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine();
Console.Write($"Произведение пар чисел(средний элемент {array[array.Length / 2]} данного массива(нечетного) возводится в квадрат, иначе костыли): ");
PrintComposition(array); */
