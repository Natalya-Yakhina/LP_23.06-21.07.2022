// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("Задайте число: ");
int num = Convert.ToInt32(Console.ReadLine());

NaturelNumber(num);

void NaturelNumber(int num)
{
    if(num == 0) return; // возврат из метода, return - прекращает работу метода
    
    Console.Write($"{num} "); // если надо в обратном порядке 6 5 4 3 2 1
    NaturelNumber(num - 1);
    // Console.Write($"{num} ");
}
