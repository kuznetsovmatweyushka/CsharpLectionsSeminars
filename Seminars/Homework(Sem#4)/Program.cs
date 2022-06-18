/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B. */
/* Console.WriteLine("Введите число A: ");
int numbA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numbB = int.Parse(Console.ReadLine());

double Power(int numbA, int numbB)
{
    double powerAB = Math.Pow(numbA, numbB);
    return powerAB;
}

double pow = Power(numbA, numbB);
Console.WriteLine(pow); */

/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе. */
/* Console.WriteLine("Введите число: ");
int sum = 0;
for(int numb = int.Parse(Console.ReadLine()) ;numb !=0;)
{
    sum = sum + (numb % 10);
    numb = numb /10;
}
Console.WriteLine(sum); */

/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран. */
/* Console.Write("Введите количество эл-в в массиве: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон цифр от: ");
int a = int.Parse(Console.ReadLine());
Console.Write("до ");
int b = int.Parse(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(a, b + 1);
    Console.Write($"{array[i]}" + " ");
} */
