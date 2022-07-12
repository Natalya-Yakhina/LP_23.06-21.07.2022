// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void SearchForPositiveNum(int[] array) // поиск положительных чисел
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
}
SearchForPositiveNum(array);
Console.WriteLine($"Количество положительных чисел = {count}");


//================ ввод в одну строку через пробел ==================

// Console.Clear();
// Console.Write("Введите числа через пробел: ");

// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);  // Split - разделитель (для последовательного ввода значений)???
// int count = 0;

// void SearchForPositiveNum (int[] array) // поиск положительных чисел
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
// }
// SearchForPositiveNum(array);
// Console.WriteLine($"Количество положительных чисел = {count}");