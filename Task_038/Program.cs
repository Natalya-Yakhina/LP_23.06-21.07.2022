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

//====================================================================
// Console.Clear();

// double[] FillArray(int size, int min, int max) //метод создания массива вещественных чисел
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max) + rnd.NextDouble();
//     }
//     return arr;
// }

// double Raznica(double[] arr)                                                          //метод пересчета пускай будет ядро
// {
//     double maxNum = 0;
//     double minNum = 0;                                                               // счет результата начинается с 0
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > maxNum) maxNum = arr[i];
//         if (arr[i] < minNum) minNum = arr[i];
//     }

//     double raz = maxNum - minNum;
//     return raz;
// }


// void PrintArray(double[] arr)                                                       //метод вывода массива со скобками (красивый массив)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < arr.Length - 1) Console.Write(Math.Round(arr[i], 2) + ",  ");       //Math.Round - обрезание после заапятой (переменная, индекс)
//         else Console.Write(Math.Round(arr[i], 2) + "]");                            //Math.Round - обрезание после заапятой (переменная, индекс)

//     }

// }

// double[] array = FillArray(4, -99, 99);              //интервал  от -99 до 99
// PrintArray(array);                                           // вывод
// Console.WriteLine();
// double sumF = Raznica(array);
// Console.WriteLine($"разница между между максимальным и минимальным элементами: {Math.Round(sumF, 3)}");


//==================================================================

// Console.Clear();
// // 1. Создание массива вещественных чисел
// double[] FillArray(int size, int min, int max)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         // array[i] = Math.Round((rnd.NextDouble() * (max-min)+min), 2); 
//         // rnd.Next(min, max) + rnd.NextDouble();
//         array[i] = Math.Round(rnd.Next(min, max) + rnd.NextDouble(), 2);// Math.Round - метод обрезки числа после запятой (переменная, индекс)
//     }
//     return array;
// }
// //2. Поиск максимального элемента массива
// double FindMaxElement(double[] array)
// {
//     int maxNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > array[maxNum])  maxNum = i;
//     }
//     return array[maxNum];
//     //return maxNum;
// }
// //3. Поиск минимального элемента массива
// double FindMinElement(double[] array)
// {
//     int minNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < array[minNum])  minNum = i;
//     }
//     return array[minNum];
//     //return minNum;
// }
// // 4. Вывод массива
// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) Console.Write("Массив [");
//         if (i < array.Length - 1) Console.Write(array[i] + ",  ");
//         else Console.Write(array[i] + "]");
//     }
//     Console.WriteLine();
// }
// double[] array = FillArray(5, -5, 5); // вывод массива
// PrintArray(array); // печать массива

// FindMaxElement(array); 
// double maxNum = FindMaxElement(array);
// Console.WriteLine($"Максимальное значение массива: {maxNum}");

// FindMinElement(array);
// double minNum = FindMinElement(array);
// Console.WriteLine($"Минимальное значение массива: {minNum}");

// double result = Math.Round(FindMaxElement(array) - FindMinElement(array), 2);
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");

Console.Clear();

Console.WriteLine("Чтобы создать массив следуйте инструкциям!");

Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

double[] CreateArrayRndInt(int sizeArray, int minimal, int maximum)
{
    double[] array = new double[sizeArray];
    Random rnd = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (maximum-minimal)+minimal), 2);
    }
    return array;
}

double SelectiontMin(double[] array)
{
    int minPositioin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minPositioin])
        {
            minPositioin = i;
        }
    }
    return array[minPositioin];
}

double SelectionMax(double[] array)
{
    int maxPositioin = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] > array[maxPositioin])
        {
            maxPositioin = i;
        }
    }
    return array[maxPositioin];
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + ",  ");
        else Console.Write(array[i] + "]");
    }
    Console.WriteLine("\b");
}

double[] array = CreateArrayRndInt(sizeArr, min, max);
PrintArray(array);

SelectiontMin(array);
var minnum = SelectiontMin(array);
Console.WriteLine($"Минимальное значение в массиве: {minnum}");

SelectionMax(array);
var maxnum = SelectionMax(array);
Console.WriteLine($"Максимальное значение в массиве: {maxnum}");

double result = SelectionMax(array) - SelectiontMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");