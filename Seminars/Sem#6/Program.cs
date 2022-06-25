/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.) */
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
int tmp;
for (int i = 0; i < array.Length / 2; i++)
{
    tmp = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = tmp;
}
Console.WriteLine();
Console.Write("Ваш перевернутый массив выглядит так: ");
PrintArray(array); */

/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины. */

/* Console.WriteLine("Введите первую сторону: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую сторону: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью сторону: ");
int c = int.Parse(Console.ReadLine());

if (a < (b + c) && b < (a + c) && c < (a + b))
{
    Console.WriteLine("Такой треугольник существует! ");
}
else Console.WriteLine("Такой треугольник не существует! "); 
 */

/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное. */
/* Console.WriteLine("Введите десятичное число: ");
int numb10 = int.Parse(Console.ReadLine());
int numb2;
string res = string.Empty;
string BinaryConverter(int numb10)
{
    for (; numb10 > 0; numb10 = numb10 / 2)
    {
        numb2 = numb10 % 2;
        res = numb2 + res;
    }
    return res;
}
Console.WriteLine(BinaryConverter(numb10)); */

/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1. */
/* Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int n0 = 0;
int n1 = 1;
int save;
for (int count = 0; count < numb; count++)
{
    save = n0;
    n0 = n1;
    n1 = n1 + save;
    System.Console.Write(save + " ");
} */

/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.  */
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
int[] array2 = new int[N];
void CopyArray(int[] original, int[] copy)
{
    for (int i = 0; i < original.Length; i++)
    {
        copy[i] = original[i];
    }
}
System.Console.WriteLine();
Console.Write("Ваша копия выглядит так: ");
CopyArray(array,array2);
PrintArray(array2); */
