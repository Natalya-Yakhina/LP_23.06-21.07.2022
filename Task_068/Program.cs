// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("n = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("m = ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("A(n,m) = " + NumberSum(a, b));

// // Ackermann's function
// //          m + 1                   , n = 0
// // A(n,m) = A(n-1, 1)               , m = 0
// //          A(n - 1, A(n, m -1))    , m > 0, n > 0      

// int NumberSum(int n, int m)
// {
//     if (n == 0) return m + 1;
//     if (m == 0) return NumberSum(n - 1, 1);
//     return NumberSum(n - 1, NumberSum(n, m - 1));
// }