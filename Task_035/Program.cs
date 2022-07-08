// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] CreateArrayRnd(int size, int min, int max) // передает размер массива, заполняется и создается массив
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr; // записывает в переменную array
}

int AmountNum(int[] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > 9 & arr[j] < 100)
            count = count + 1;
    }
    return count;
}

void PrintArray(int[] arr) // печать массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] array = CreateArrayRnd(123, 10, 100); // нам нужен массив и диапозон
PrintArray(array);
int result = AmountNum(array);
Console.WriteLine();
Console.WriteLine($"Количество элементов массива, начения которых лежат в отрезке [10,99] : {result}");


// ===== решение без методов =====

// int[] array = new int[123];
// int count = 0;
// Random rnd = new Random();

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = rnd.Next(10, 99);
// Console.Write(array[i] + " ");
// }

// Console.WriteLine();

// for (int j = 0; j < array.Length; j++)
// {
// if(array[j] > 9 & array[j] < 100) 
// count = count + 1;
// }
// Console.WriteLine();
// Console.Write("Массив совержит следующее количество элементов из отрезка [10,99] - ");
// Console.Write(count);


// ===== другой вариант ======
// Console.Write("Введите длинну массива: ");
// int sizeArr = int.Parse(Console.ReadLine());

// Console.Write("Введите минимальное значение элементов массива: ");
// int minimal = int.Parse(Console.ReadLine());

// Console.Write("Введите максимальное значение элементов массива: ");
// int maximum = int.Parse(Console.ReadLine());

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// int FindNums (int[] arr)
// {
// int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }

// void PrintArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i==0) Console.Write("Массив [");
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i] + "]");
        
//     }
// }

// int[] array = CreateArrayRndInt (sizeArr, minimal, maximum);
// int count = FindNums(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {count}");