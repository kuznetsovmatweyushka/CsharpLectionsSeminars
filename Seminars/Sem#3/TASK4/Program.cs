/* Задача 22: Напишите программу, которая 
принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N. */
Console.WriteLine("Введите N:");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count <= N)
{
    Console.Write(Math.Pow(count, 2) + " ");
    count++;
}
