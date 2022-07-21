// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.Write("Задайте число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = Convert.ToInt32(Console.ReadLine());

//===========простой способ=============
// void NaturelNumber(int m, int n)
// {
//         Console.Write($"{m} ");
//         if(m == n) return;
//         NaturelNumber(m + 1, n);
// }
// NaturelNumber(m, n);

void NaturelNumber(int m, int n)
{
    if(m <= n)
    {
        Console.Write($"{m} ");
        if(m == n) return;
        NaturelNumber(m + 1, n);
    }
    else if(m > n) // если нужно обратно от n до m
    {
        Console.Write($"{m} ");
        if(m == n) return;
        NaturelNumber(m - 1, n);
    }
}
NaturelNumber(m, n);