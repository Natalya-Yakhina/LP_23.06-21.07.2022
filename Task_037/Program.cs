// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();
int[] array = new int[7];

void FillArray(int[] arr) // ввод массива
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
}

void PrintArray(int[] arr) // вывод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

void Proizved(int[] arr) 
{
    int i = 0;
    Console.Write("[");
    while (i < arr.Length / 2 + arr.Length % 2)
    {
        Console.Write(arr[i] * arr[arr.Length - i - 1] + ",");
        i++;
    }
    if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");

    Console.Write("]");
}

FillArray(array);
PrintArray(array);
Proizved(array);


// ===== исходное решение без методов(на семинаре) =====
// Console.Clear();
// int n = 3;
// int[] arr = new int[n];
// Random rnd = new Random();

// for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 10);
//         Console.Write(arr[i] + " ");
//     }
// Console.WriteLine();

// int j = arr.Length - 1;
//     for (int i = 0; i < (arr.Length + 1) / 2; i++)
//     {
//     Console.Write(arr[i] * arr[j] + " ");
//     j--;
//     }

// if (n % 2 > 0)
// {
//     Console.Write(arr[arr.Length / 2 + 1]);
// }