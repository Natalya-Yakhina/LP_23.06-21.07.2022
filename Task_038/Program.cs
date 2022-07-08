// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



// Console.WriteLine("Введите количество элементов n=");
// // int n = Convert.ToInt32(Console.ReadLine());
// // double[] array  = new double[n];
// // double result = 0;

// // double maxB = array[0];
// // for (int i = 0; i < array.Length; i++)
// // {
// //     array[i] = new Random().Next(1, 9);
// //     Console.Write(array[i] + " ");
// //     if (array[i] > maxB)
// //     {
// //         maxB = array[i];
// //     }    
// // }
// // double minA = array[0];
// // for (int j = 0; j< array.Length; j++)
// // {
// //     if (minA > array[j])
// //     {
// //         minA = array[j];
// //     }
// // }
// // result = maxB - minA;

// // Console.WriteLine(" ");   
// // Console.WriteLine(result + " Разница ");   


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
        if(newArray[a] >= maxValue) maxValue = newArray[a]; 
        if(newArray[a] <= minValue) minValue = newArray[a]; 
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



3


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(double[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        Console.Write("Enter " + index + " element of the array ");
        collection[index] = Convert.ToDouble(Console.ReadLine());
    }
    for (int index = 0; index < collection.Length; index++)
    {
        Console.Write(collection[index] + " ");
    }
}
void Diff(double[] number)
{
    double max = Double.MinValue;
    double min = Double.MaxValue;
    int ind = 0;
    while (ind < number.Length)
    {
        if (number[ind] > max) max = number[ind];
        if (number[ind] < min) min = number[ind];
        ind++;
    }
    double diff = max - min;
    Console.WriteLine();
    Console.Write("Difference between max and min: " + diff);
}
Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
Diff(array);