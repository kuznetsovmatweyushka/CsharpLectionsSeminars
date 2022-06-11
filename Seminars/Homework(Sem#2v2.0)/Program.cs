/* Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа. 
Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine().ToString();
Console.WriteLine("2: "+ number[1]); */

/* Задача 4: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным. */
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number <= 0 || number > 7)
{
    Console.WriteLine("Введите корректное число");
}
else if (number < 6)
{
    Console.WriteLine("Будни =(");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной!!!");
}

