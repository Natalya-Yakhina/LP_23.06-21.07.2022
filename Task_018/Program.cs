// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
Console.Write("Четверть: ");
int x = Convert.ToInt32(Console.ReadLine()); // номер четверти

    switch (x)
    {
    case 1: Console.WriteLine("xc > 0 и yc > 0"); break;
    case 2: Console.WriteLine("xc < 0 и yc > 0"); break;
    case 3: Console.WriteLine("xc < 0 и yc < 0"); break;
    case 4: Console.WriteLine("xc > 0 и yc < 0"); break;
    default: Console.WriteLine("Нет такого дня недели"); break;
    }