/* Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деление. */
Console.WriteLine("Введите число №1: ");
int numbA =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int numbB =int.Parse(Console.ReadLine());
int remain = numbB % numbA;
if (remain == 0)
{
    Console.Write("Число №2 кратно числу №1.");
}
else
{
    Console.Write("Число №2 некратно числу №1, остаток равен: "+remain);
}