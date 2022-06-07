//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a == b * b)
{

    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}