/* Задача 21: Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 2D 
пространстве. */
Console.WriteLine("Введите Xa: ");
double Xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Ya: ");
double Ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Xb: ");
double Xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Yb: ");
double Yb = double.Parse(Console.ReadLine());
double distanse = Math.Sqrt(Math.Pow(Xb - Xa,2) + Math.Pow(Yb - Ya,2));
Console.WriteLine("Расстояние :" + distanse);