/* Задача 18: Напишите программу, которая по 
заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y). */
Console.WriteLine("Введите номер четверти: ");
int chapter = int.Parse(Console.ReadLine());
if (chapter == 1)
{
    Console.WriteLine("Четверть №1. Диапазон возможных координат: X > 0, Y > 0 ");
}
else if (chapter == 2)
{
    Console.WriteLine("Четверть №2. Диапазон возможных координат: X < 0, Y > 0 ");
}
else if (chapter == 3)
{
    Console.WriteLine("Четверть №3. Диапазон возможных координат: X < 0, Y < 0 ");
}
if (chapter == 4)
{
    Console.WriteLine("Четверть №4. Диапазон возможных координат: X > 0, Y < 0 ");
}