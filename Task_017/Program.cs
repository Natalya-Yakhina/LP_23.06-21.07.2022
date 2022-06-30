// Напишите программу, которая принимает на вход координаты точки (x, y), 
// причем x y не равны нулю  и выдает номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.Write("Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некорректные координаты");

// через метод:
string Quarter(int xc, int yc) //формальный параметр c - координата
{
    if (xc > 0 && yc > 0) return "Первая четверть"; // возврат ответа
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены некорректные координаты";
}
string result = Quarter(x, y); //возврат результата 

Console.WriteLine(result);
