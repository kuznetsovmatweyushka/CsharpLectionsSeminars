//Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ваше число " + a);
int min = -a;
int max = a;
while (min <= max)
{
    Console.Write(min);
    min ++;  
}
