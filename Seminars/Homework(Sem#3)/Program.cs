﻿/* Задача 19: Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно 
палиндромом. */

/* Console.WriteLine("Введите пятизначное число: ");
string digit = int.Parse(Console.ReadLine()).ToString();
int numb = digit.Length;
int numb0 = digit[0];
int numb4 = digit[4];
int numb1 = digit[1];
int numb3 = digit[3];
if (numb != 5)
{
    Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число!!!");
}
else if (numb0 == numb4 & numb1 == numb3)
{
    Console.WriteLine("Число является полиндромом. ");
}
else Console.WriteLine("Число не является полиндромом. ");  */

/* Задача 21: Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.*/

/* Console.WriteLine("Введите Xa: ");
double Xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Ya: ");
double Ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Za: ");
double Za = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Xb: ");
double Xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Yb: ");
double Yb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Zb: ");
double Zb = double.Parse(Console.ReadLine());
double distanse = Math.Sqrt(Math.Pow(Xb - Xa, 2)
                            + Math.Pow(Yb - Ya, 2)
                            + Math.Pow(Zb - Za, 2));
Console.WriteLine("Расстояние :" + Math.Round(distanse,2)); */

/* Задача 23: Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

/* Console.WriteLine("Введите N:");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count <= N)
{
    Console.Write(Math.Pow(count, 3) + " ");
    count++;
} */