/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее. */

/* Console.WriteLine("Первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Второе число: ");
int b = int.Parse(Console.ReadLine());

if (a < b)
{
    Console.WriteLine("Большее чило: " + b);
}
Console.WriteLine("Меньшее число: "+ a); */

/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
 */

/* Console.WriteLine("Первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Второе число: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Наибольшее: " + max); */

/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
 */

/* Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Четное!");
}
else
{
    Console.WriteLine("Нечетное!");
} */

/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N. */

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;
while (b < a - 1)
{
    b += 2;
    Console.Write(b + " ");
}