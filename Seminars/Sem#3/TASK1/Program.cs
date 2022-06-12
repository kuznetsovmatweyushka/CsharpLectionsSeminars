/* Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
номер четверти плоскости, в которой находится эта 
точка. */
Console.WriteLine("Введите X: ");
double X = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
double Y = double.Parse(Console.ReadLine());
if (X > 0 & Y > 0)
{
    Console.WriteLine("Вы находитесь в четврети №1.");
}
else if (X < 0 & Y > 0)
{
    Console.WriteLine("Вы находитесь в четврети №2.");
}
else if (X > 0 & Y < 0)
{
    Console.WriteLine("Вы находитесь в четврети №4.");
}
else if (X < 0 & Y < 0)
{
    Console.WriteLine("Вы находитесь в четврети №3.");
}