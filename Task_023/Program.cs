﻿// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.
// 3 -> 1, 4, 9
// 5 -> 1, 4, 27, 64, 125

Console.WriteLine("Введите  число: ");
int n = int.Parse(Console.ReadLine()); // аналог конверт только строку

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Куб числа {i} = {i * i * i}");
}