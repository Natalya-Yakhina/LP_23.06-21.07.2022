// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Задайте число для возведения в степень: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте степень для числа: ");
int m = Convert.ToInt32(Console.ReadLine());


void PowerNumber(int num, int power, int memory)
{   
    if(power > 1)
    {
        num = num * memory;
        PowerNumber(num, power - 1, memory);
        return;
    } 
    else
    {
        Console.Write($"число {n} в степени {m} --> {num} ");
    }
}
PowerNumber(n, m, n);

// Console.WriteLine("Задайте число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PowerNumber(A, B));


// int PowerNumber(int number, int power)
// {
//     if (power == 1) return number;
//     return number * PowerNumber(number, --power);
//     Console.Write($"{power} ");
//     PowerNumber(A, B);
// }