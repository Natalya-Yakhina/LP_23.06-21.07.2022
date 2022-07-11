// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины
// А < B + C

Console.WriteLine("Введите первую сторону: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону: ");
int numC = Convert.ToInt32(Console.ReadLine());

void Triagle(int a, int b, int c)
{
    if(a < b + c && b < a +c && c < a + b)
    Console.WriteLine("Треугольник существует");
    else 
    {
    Console.WriteLine ("Треугольник не существует");
    }
}
Triagle(numA, numB, numC);