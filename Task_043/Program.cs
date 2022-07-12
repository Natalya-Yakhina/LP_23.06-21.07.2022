// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// по системе уравнений найти х и определить координаты
// вводит 4 значения пользователь


Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void Intersection(double b1, double k1, double b2, double k2) // поиск значений (x ; y) точки пересечения
{
    double x = 0;
    double y = 0;

    x = Math.Round ((b2 - b1) / (k1 - k2), 1); // Math.Round - округляет значение до ближайшего целого или указанного количества десятичных знаков
    y = Math.Round (k1 * x + b1, 1); 
    Console.Write($"Точка пересечения двух прямых = ({x} ; {y})");
}
Intersection(b1, k1, b2, k2);
