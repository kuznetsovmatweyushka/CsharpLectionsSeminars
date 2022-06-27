/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь. */
Console.WriteLine("Введите числа: ");
string digits = Console.ReadLine();
string[] array = digits.Split('.', ' ', ',');
int count = 0;
int num;
int More0(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        num = int.Parse(array[i]);

        if (num > 0)
        {
            count++;
        }
    }
    return count;
}
int more0 = More0(array);
Console.WriteLine($"Количество чисел больше 0: " + more0);

/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем. */
/* Console.WriteLine("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
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
    (int, int) Point(int b1, int k1, int b2, int k2)
    {

        var x = (b2 - b1) / (k1 - k2);
        var y = k2 * x + b2;
        return (x, y);
    }
    var res = Point(b1, k1, b2, k2);
    Console.WriteLine($"{res}");
} */

