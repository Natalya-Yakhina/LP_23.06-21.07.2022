// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.Write("Задайте число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

int NumberSum(int a, int b)
{
    if (a > b) return 0;
    return a + NumberSum(a + 1, b);
}

Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum = " + NumberSum(m, n));