// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[4];

void FillArray(int[] arr) // ввод массива
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

void PrintArray(int[] arr) // вывод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

void Chetnost(int[] arr) // метод для подсчета количества четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве -> {count}");
}

FillArray(array);
PrintArray(array);
Chetnost(array);




// ==== 2 вариант ввода =====
// Console.Clear();

// int[] FillArray(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr) // вывод массива
// {
//     for(int i = 0; i < arr.Length; i++ )
//     {
//         if (i == 0) Console.Write("[");
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i] + "]");
//     }
// }
// Console.WriteLine();

// int[] array = FillArray(9, 100, 1000);
// PrintArray(array);