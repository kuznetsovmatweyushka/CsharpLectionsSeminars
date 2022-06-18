/* Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А. */
/* int Func(int numb)
{
    int res = 0;
    for (int i = 0; i <= numb; i++)
    {
        res += i;
    }
    return res;
}
System.Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {A} = " + Func(A)); */

/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе. */
/* int Length(string numb)
{
    int length = numb.Length;
    return length;
}
Console.WriteLine("Введите число: ");
string numb = int.Parse(Console.ReadLine()).ToString();
Console.Write($"В числе {numb}: " + Length(numb) + " цифр(ы)"); */

/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N. */
/* int Comp(int numb)
{
    int result = 1;
    for (int i = 1; i < numb + 1; i++)
    {
        result *= i;
    }
    if (numb == 0 | numb < 0)
        result = 0;
    return result;
}
Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine());
Console.WriteLine($"Факториал числа {numb} равен: " +Comp(numb)); */

/* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке. */
/* Console.WriteLine("Введите желаемое количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
var r = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(0, 2);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
PrintArray(array);
 */