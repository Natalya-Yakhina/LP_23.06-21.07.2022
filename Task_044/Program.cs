// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибонначи: 0 и 1
// Если N = 5 -- 0 1 1 2 3
// Если N = 3 -- 0 1 1
// Если N = 7 -- 0 1 1 2 3 5 8

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

Console.Clear();
Console.Write("Введите числo N: ");
int num = int.Parse(Console.ReadLine());

void Fibonacci(int num)
{
    int[] fib = new int[num];
    {
        fib[0] = 0;
        fib[1] = 1;
        Console.Write("0 1 ");
        for (int i = 2; i < num; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
            Console.Write(fib[i] + " ");
        }
    }
}
Fibonacci(num);

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void Fibonacci(int in_num)
// {
// int f1 = 0;
// int f2 = 1;
// int sum = 0;
// Console.Write($"{f1} {f2}");
// for (int i = 1; i <= in_num; i++)
// {
// sum = f1 + f2;
// f1 = f2;
// f2 = sum;
// Console.WriteLine($"F({i}) = {sum}");
// }
// }
// Fibonacci(n);
