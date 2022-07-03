/* Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N. */

/* Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
void Numbers(int n)
{
    if (n == 0)
    {
        return;
    }
    Numbers(n - 1);
    Console.Write(n + " ");
}
Numbers(n); */

/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N. */
/* Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
void Numbers(int m, int n)
{
    if (m == n) return;
    Console.Write(m + " ");
    Numbers(m + 1, n);
}
Numbers(m, n); */

/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */
/* Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
int Summ(int n)
{
    if (n == 0) return 0;
    return n % 10 + Summ(n / 10);
}
Console.WriteLine(Summ(n)); */

/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии. */

/* Console.WriteLine("Введите A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B: ");
int b = int.Parse(Console.ReadLine());
double Power(int a, int b)
{
    if (b == 0) return 1;
    if (b < 0) return (1.0 / a) * Power(a, b + 1);
    return a * Power(a, b - 1);
}
Console.WriteLine(Power(a, b)); */
