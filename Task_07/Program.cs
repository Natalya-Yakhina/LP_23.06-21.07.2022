﻿// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// 5, 25 да
// -4, 16 -да
// 25, 5 - да
// 8, 9 - нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if ((a * a == b) || (b * b == a))
Console.WriteLine ("Является");
else Console.WriteLine ("Не является");
