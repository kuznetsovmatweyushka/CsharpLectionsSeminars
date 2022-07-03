/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */
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
void Replace(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        var save = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = save;
    }
}
FillArray(array, a, b);
PrintArray(array);
Console.WriteLine("Массив с замененными строками: ");
Replace(array);
PrintArray(array); */

/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */
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
void Replace(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        Console.WriteLine("Массив с замененными строками и столбцами: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[j, i]} ");
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Невозможно заменить строки на столбцы! ");
}
FillArray(array, a, b);
PrintArray(array);
Replace(array); */

/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */
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
void Frequency(int[,] array)
{
    int[] mass = new int[array.Length];
    int k = 0;
    bool find = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            find = false;
            for (int n = 0; n < k; n++)
            {
                if (mass[n] == array[i, j])
                {
                    find = true;
                    break;
                }
            }
            if (!find)
            {
                mass[k] = array[i, j];
                k++;
            }
        }
    }
    Console.WriteLine("Массив уникальных элементов: ");
    for (int i = 0; i < k; i++)
    {
        Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
    for (int s = 0; s < k; s++)
    {
        int num = mass[s];
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == num) count++;
            }
        }
        Console.WriteLine($"{num} встречается {count} раз");
    }
}
FillArray(array, a, b);
PrintArray(array);
Frequency(array); */

/* Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива. */
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
PrintArray(array);
void FindMin(int[,] array)
{
    int mini = 0;
    int minj = 0;
    int min = array[mini, minj];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                mini = i;
                minj = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент равен {min} на {mini} строке, во {minj} столбце. ");
    int[,] mass = new int[m - 1, n - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != mini & j != minj)
            {
                // Console.Write(array[i, j] + " ");
                int k = i;
                if (i > mini) k = i - 1;
                int l = j;
                if (j > minj) l = j - 1;
                mass[k, l] = array[i, j];
            }
        }
    }
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
}
FindMin(array); */

/* Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника */
/* Console.Write("Введите количество строк: ");
int size = int.Parse(Console.ReadLine());
for (int i = 0; i < size; i++)
{
    for (int j = size; j > i; j--)
    {
        Console.Write(" ");
    }
    int val = 1;
    for (int j = 0; j <= i; j++)
    {
        Console.Write(val + " ");
        val = val * (i - j) / (j + 1);
    }
    Console.WriteLine();
} */
