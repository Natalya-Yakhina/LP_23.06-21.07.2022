// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 10 мин

// Console.Write ("введите число и получите день недели:");
// int Mounday = 1;
// int Tuesday = 2;
// int Wednesday = 3;
// int Thursday = 4;
// int Friday = 5;
// int Saturday = 6;
// int Sunday = 7;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Нет такого дня недели"); break;
}
// Console.ReadKey();