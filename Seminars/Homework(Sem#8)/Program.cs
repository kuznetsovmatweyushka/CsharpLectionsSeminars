/* Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника */
/* Console.Write("Введите количество строк: ");
int size = int.Parse(Console.ReadLine());
void PascalTriangle(int size)
{
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
    }
}
PascalTriangle(size); */

/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */
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
void BubbleSort(int[,] array)
{
    int[] temp = new int[m * n];
    int z = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[z] = array[i, j];
            z++;
        }
    }
    int help = temp[0];
    for (int k = 0; k < temp.Length - 1; k++)
    {
        for (int l = 0; l < temp.Length - 1; l++)
        {
            if (temp[l] > temp[l + 1])
            {
                help = temp[l];
                temp[l] = temp[l + 1];
                temp[l + 1] = help;
            }
        }
    }
    int[,] sort = new int[m, n];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sort[i, j] = temp[x];
            x++;
        }
    }
    for (int i = 0; i < sort.GetLength(0); i++)
    {
        for (int j = 0; j < sort.GetLength(1); j++)
        {
            Console.Write($"{sort[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray(array, a, b);
Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine("Отсортированный массив:");
BubbleSort(array); */

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

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
Console.WriteLine("Ваш массив: ");
PrintArray(array);
void MinSumm(int[,] array)
{
int minRowSum = int.MaxValue;
int indexMinRow = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        rowSum += array[i, j];

    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
Console.WriteLine("Строка с минимальной суммой элементов");
for (int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[indexMinRow, j] + " ");
Console.WriteLine();
Console.WriteLine("Сумма строки:" + minRowSum);
}
MinSumm(array); */

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */
/* Console.WriteLine("Введите количество строк первой матрицы: ");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы: ");
int m2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 == m2)
{
    int[,] matrix1 = new int[m1, n1];
    int[,] matrix2 = new int[m2, n2];
    Console.WriteLine("Введите диапазон чисел от: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите диапазон чисел до: ");
    int b = int.Parse(Console.ReadLine());
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
    FillArray(matrix1, a, b);
    FillArray(matrix2, a, b);
    Console.WriteLine("Первая матрица:");
    PrintArray(matrix1);
    Console.WriteLine("Вторая матрица:");
    PrintArray(matrix2);
    int[,] Multiplication(int[,] array1, int[,] array2)
    {
        int[,] m = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); ++i)
            for (int j = 0; j < matrix2.GetLength(0); ++j)
                for (int k = 0; k < matrix2.GetLength(1); ++k)
                    m[i, k] += matrix1[i, j] * matrix2[j, k];
        return m;
    }
    int[,] mult = Multiplication(matrix1, matrix2);
    Console.WriteLine("Произведение матриц:");
    PrintArray(mult);
}
else
{
    Console.WriteLine("Произведения не существует!");
} */

/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */
/* int[,,] arr = new int[3, 2, 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            arr[i, j, k] = new Random().Next(10, 99);
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} индекс ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
PrintArray(arr); */

/* Задача 62: Заполните спирально массив 4 на 4 */
/* Console.WriteLine("Введите размер матрицы: ");
int n = int.Parse(Console.ReadLine());
int[,] GetSpire(int n)
{
    var result = new int[n, n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = rand.Next(n, n);
    for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
    {
        for (int j = padding; j < n - padding; j++)
            result[padding, j] = currentChar;
        for (int j = padding; j < n - padding; j++)
            result[n - padding - 1, j] = currentChar;
        for (int i = padding + 2; i < n - padding - 1; i++)
            result[i, padding] = currentChar;
        for (int i = padding + 1; i < n - padding - 1; i++)
            result[i, n - padding - 1] = currentChar;
        currentChar = 1 - currentChar;
        result[padding + 1, padding] = currentChar;
    }
    if (n % 2 != 0 && result[0, 0] == 1)
        result[n / 2, n / 2] = 1;
    return result;
}
GetSpire(n);
int[,] a = GetSpire(n);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
} */