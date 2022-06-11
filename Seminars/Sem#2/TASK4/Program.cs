/* Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно 7 и
23. */
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int remain7 = number % 7;
int remain23 = number % 23;
if (remain7 == 0)
{
    if (remain23 == 0)
    {
        Console.WriteLine("Число одновременно кратно 7 и 23. Поздравляем!");
    }
    else
    {
        Console.WriteLine("Число не кратно 23. Не расстраивайся =)");
    }
}
else
{
    Console.WriteLine("Число не кратно 7. Не расстраивайся =)");
}