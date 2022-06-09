/* Напишите программу, которая принимает
на вход трёхзначное число и на выходе
показывает последнюю цифру этого числа. */

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int remain = number % 10;
Console.Write("Последняя цифра числа: " + remain);
