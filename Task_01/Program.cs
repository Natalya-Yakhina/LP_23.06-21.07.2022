﻿// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

    Console.Write ("введите первое числo:  ");
    int num1 = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("введите второе число:  ");
    int num2 = Convert.ToInt32 (Console.ReadLine());

    if (num1 == num2 * num2) 
{ 
    Console.Write ("является ли квадратом: да");
} 
else
{
    Console.Write ("является ли квадратом: нет");
} 
