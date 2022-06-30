// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.Clear();
// Console.WriteLine("Введите координаты точки");
// Console.Write("ХA: ");
// int XA = Convert.ToInt32(Console.ReadLine());
// Console.Write("YA: ");
// int YA = Convert.ToInt32(Console.ReadLine());
// Console.Write("XB: ");
// int XB = Convert.ToInt32(Console.ReadLine());
// Console.Write("YB: ");
// int YB = Convert.ToInt32(Console.ReadLine());

// double AB = Math.Sqrt(Math.Pow((XA - XB), 2) + Math.Pow((YA -YB), 2));
// Console.WriteLine(Math.Round(AB, 2));

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6, 8); B (2,1, -7) -> -15,84
// A (7,-5, 0); B (1,-1, 9) -> 11,53

Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.Write("ХA: ");
int XA = Convert.ToInt32(Console.ReadLine());
Console.Write("YA: ");
int YA = Convert.ToInt32(Console.ReadLine());
Console.Write("ZA: ");
int ZA = Convert.ToInt32(Console.ReadLine());
Console.Write("XB: ");
int XB = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int YB = Convert.ToInt32(Console.ReadLine());
Console.Write("ZB: ");
int ZB = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((XA - XB), 2) + Math.Pow((YA -YB), 2) + Math.Pow((ZA -ZB), 2));
Console.WriteLine(Math.Round(AB, 2));
