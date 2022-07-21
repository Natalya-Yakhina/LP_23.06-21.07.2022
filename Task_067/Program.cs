// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Задайте число: ");
int num = Convert.ToInt32(Console.ReadLine());

void SumNumber(int num, int sum)
{
    int ostatok = num % 10;
    sum = sum + ostatok;
    if(ostatok == 0)
    {
        Console.Write($"Сумма цифр числа --> {sum}");
        return;
    }
    num /= 10;
    SumNumber(num, sum);
}
SumNumber(num, 0);


// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(RecursionSum(number));

// int RecursionSum(int n)
// {
//     if (n == 0) return 0;
//     return n % 10 + RecursionSum(n / 10);
// }