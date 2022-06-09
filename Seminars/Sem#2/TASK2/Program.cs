/* Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа. */
int randnumb = new Random().Next(10, 99);
Console.WriteLine("Ваше случайное число: " + randnumb);
int firstnumb = randnumb / 10;
int secondnumb = randnumb % 10;
Console.WriteLine("Первая цифра: " + firstnumb);
Console.WriteLine("Вторая цифра: " + secondnumb);
int maxnumb = 0;
if (firstnumb > secondnumb)
{
    maxnumb = firstnumb;
}
else
{
    maxnumb = secondnumb;
}
Console.WriteLine("Наибольшая цифра числа: " + maxnumb);