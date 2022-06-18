/* Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А. */
/* Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int res = 0;
for (int i = 0; i <= numb; i++)
{
    res += i;
}
Console.WriteLine($"Сумма чисел от 1 до {numb} = " + res); */

/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе. */
/* Console.WriteLine("Введите число: ");
string numb = int.Parse(Console.ReadLine()).ToString();
int length = numb.Length;
Console.WriteLine($"В числе {numb} - {length} цифр(ы)"); */

/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N. */
/* Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i < numb + 1; i++)
{
    result *= i;
}
Console.WriteLine(result); */

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
    Console.Write(array[i] + ",");
}
 */