/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь. */
/* Console.WriteLine("Введите числа: ");
string digits = Console.ReadLine();
string[] array = digits.Split('.', ' ', ',');
double count = 0;
double More0(string[] array)
{
for (double i = 0; i < array.Length; i++)
{
    double num = double.Parse(array[i]);
    if (num > 0)
    {
        count++;
    }
}
return count;
}
double more0 = More0(array);
Console.WriteLine($"Количество чисел больше 0: " + more0); */

/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем. */
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
if (k1 == k2)
{
    Console.WriteLine("Прямые совпадают!");
}
else if (b1 == b2)
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    double Point(double b1, double k1, double b2, double k2)
    {

        double x = (b2 - b1) / (k1 - k2);
        return x;
    }
    double x = Math.Round(Point(b1, k1, b2, k2), 2);
    Console.WriteLine($"({x} ; {Math.Round((k2 * x + b2), 2)})");
}

