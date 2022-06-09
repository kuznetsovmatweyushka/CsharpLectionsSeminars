/* Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа. */
/* Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine().ToString();
Console.WriteLine("2: "+ number[1]); */

/* Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.
 */
/* string number = new Random().Next(111,999).ToString();
Console.WriteLine("Ваше рандомное трехзначное число: " + number);
Console.Write("Ваше двухзначное число из трехзначного: " + number[0] + number[2]); */

/* Задача 3: Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет. */
/* Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine().ToString();
int length = number.Length;
Console.WriteLine("Количество цифр в числе: " + length);
if (length < 3)
{
    Console.WriteLine("Третьей цифры нет ");
}
else
{
    Console.WriteLine("Третья цифра числа: " + number[2]);
} */

/* Задача 4: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
 */
/* Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number <= 0 || number > 7) 
{
    Console.WriteLine("Введите корректное число");
}
else if (number < 6)
{
    Console.WriteLine("Будни =(");
}
else if (number == 6)
{
    Console.WriteLine("Выходной!!!");
}
else if (number == 7)
{
    Console.WriteLine("Выходной!!!");
} */

