// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//======================== 1 вариант решения ===================================
// int[] FillArray(int size, int min, int max) // метод передает размер массива, заполняется и создается массив
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max);
//     }
//     return arr; // записывает в переменную arr
// }

// int FindMaxMinElement(int[] array) // находит минимальный и максимальный элемент массива
// {
//     int max = array[0];
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (max < array[i])  max = array[i];
//         if (min > array[i])  min = array[i];
//     }
//     return max - min;
// }

// void PrintArray(int[] arr) // вывод значений массива
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i] + "]");
//     }
// }

// void PrintDif(int dif) // вывод разницы между максимальным и минимальным элементом
// {
//     Console.WriteLine();
//     Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {dif}");
// }

// int[] arr = FillArray(7, 0, 80);
// PrintArray(arr);
// int difMaxMin = FindMaxMinElement(arr);
// PrintDif(difMaxMin);


// ===============вещественные числа============================
// Console.Write("Введите количество элементов в массиве: ");
// int num = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[num];

// void FillArray(double[] newArray)
// {
//      // Console.WriteLine("Массив: ");
//      for (int i = 0; i < newArray.Length; i++)
//      {
//          newArray[i] = new Random().Next(1, 25);
//      }  

//     double maxValue = 0;
//     double minValue = 0;
//     for (int a = 0; a < newArray.Length; a++)
//     {
//         if (newArray[a] >= maxValue) maxValue = newArray[a];
//         if (newArray[a] <= minValue) minValue = newArray[a];
//     }
//     double result = maxValue - minValue;
//     Console.WriteLine($"Макс число в массиве: {maxValue}");
//     Console.WriteLine($"Мин число в массиве: {minValue}");
//     Console.WriteLine($"разницa между максимальным и минимальным элементов массива: {result}");
// }

// void PrintArray(double[] newArray) // вывод значений массива
// {
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < newArray.Length - 1) Console.Write(newArray[i] + ", ");
//         else Console.Write(newArray[i] + "]");
//     }
// }  

// FillArray(array);
// PrintArray(array);
// // PrintDif(array);


void FillArray(double[] newArray)
{
    Console.Write("Массив: ");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(-10, 10);
        Console.Write($"{newArray[i]} ");
    }

    Console.WriteLine();
    double maxValue = 0;
    double minValue = 0;
    for (int a = 0; a < newArray.Length; a++)
    {
        if (newArray[a] >= maxValue) maxValue = newArray[a];
        if (newArray[a] <= minValue) minValue = newArray[a];
    }
    double result = maxValue - minValue;
    Console.WriteLine($"Макс число в массиве: {maxValue}");
    Console.WriteLine($"Мин число в массиве: {minValue}");
    Console.WriteLine($"разницa между максимальным и минимальным элементов массива: {result}");
}
Console.WriteLine("введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
FillArray(array);