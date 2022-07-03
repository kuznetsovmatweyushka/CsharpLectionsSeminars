/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N. */
/* Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
void Numbers(int m, int n)
{
    if (m == n) return;
    if (m < n)
    {
        Console.Write(m + " ");
        Numbers(m + 1, n);
    }
    if (m > n)
    {
        Console.Write(m + " ");
        Numbers(m - 1, n);
    }
}
Numbers(m, n); */
/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. */
/* Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
int Numbers(int m, int n)
{
    if (m > n) return 0;
    return m + Numbers(m + 1, n);
}
int res = Numbers(m, n);
Console.WriteLine(res);  */

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.  */
/* Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
int Accerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 & n == 0) return Accerman(m - 1, 1);
    if (m > 0 & n > 0) return Accerman(m - 1, Accerman(m, n - 1));
    return Accerman(m, n);
}
Console.WriteLine("A(m,n) = " + Accerman(m, n));  */