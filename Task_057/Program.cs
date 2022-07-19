// Задача 57. Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

void FillMatrixWithRndIntValue(int[,] in_array, int int_minValue, int int_maxValue) // метод заполнения матрицы случайными значениями
{
    var rndGenerator = new Random();

    for (int i = 0; i < in_array.GetLength(0); i++)
    {
        for (int j = 0; j < in_array.GetLength(1); j++)
        {
            in_array[i, j] = rndGenerator.Next(int_minValue, int_maxValue+1);
        }
    }
}

void PrintMatrix(int[,] in_array)
{
    Console.WriteLine($"Массив размерности: [{in_array.GetLength(0)}, {in_array.GetLength(1)}]");

    for (int i = 0; i < in_array.GetLength(0); i++)
    {
        for (int j = 0; j < in_array.GetLength(1); j++)
        {
        if (j == 0) Console.Write("|");
        if (j < in_array.GetLength(1) - 1) Console.Write($" | [{i}][{j}] = {in_array[i, j], 4} | ");
        else Console.Write($" | [{i}][{j}] = {in_array[i, j], 4} || ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] in_array) // метод отображения одномерного массива
{
    for(int i = 0; i < in_array.GetLength(0); i++)
    {
        if(i == 0) Console.Write("[");
        if(i < in_array.GetLength(0) - 1) Console.Write($" {in_array[i], 4};");
        else Console.Write($" {in_array[i], 4} ]");
    }
}

int[] ConvertToOneDimensionArray(int[,] in_array) // конвертирование в одномерный массив двумерного
{
    int[] arrayForMetod = new int[in_array.Length];
    int count = 0;
    Console.WriteLine($"in_array.Length = {in_array.Length}");
    Console.WriteLine($"in_array.GetLength(0) = {in_array.GetLength(0)}");
    Console.WriteLine($"in_array.GetLength(0) = {in_array.GetLength(1)}");

    for(int i = 0; i < in_array.GetLength(0); i++)
    {
        for(int j = 0; j < in_array.GetLength(1); j++)
        {
            arrayForMetod[count] = in_array[i,j];
            count++;
        }
    }
    return arrayForMetod;
}

int[] SummUniqValuesInArray(int[] in_array, int[] in_array2) // подсчет всех элементов входящих в массив
{
    int count = 0; // перебираем одномерный массив
    int actualValue = in_array[0];
    int iForSecondArray = 0;

    for(int i = 0; i < in_array.Length; i++)
    {
        if(actualValue == in_array[i])
        {
            count++;
        }
        else
        {
            actualValue = in_array[i];
            in_array2[iForSecondArray] = count;
            count = 1;
            iForSecondArray++;
        }
        if(i == in_array.Length - 1)
        {
            in_array2[iForSecondArray] = count;
        }
    }
    return in_array2;
}
Console.Write("Введите количество строк в двумерном массиве m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном массиве n = ");
int n = int.Parse(Console.ReadLine());

int[,] arrayForTask = new int[m, n];
FillMatrixWithRndIntValue(arrayForTask, 0, 40); // вывод размерности массива
PrintMatrix(arrayForTask);

int[] arrayResult = ConvertToOneDimensionArray(arrayForTask); // конвертация в одномерный массив
PrintArray(arrayResult);
Array.Sort(arrayResult); // сортировка по возрастанию
int[] unuqArray = arrayResult.Distinct().ToArray(); // перебиваем количество уникальных элементов которые встречаются
Console.WriteLine("массив основной");
PrintArray(arrayResult);
Console.WriteLine("массив отсортированный");
PrintArray(unuqArray);

unuqArray = SummUniqValuesInArray(arrayResult, unuqArray); // количество повторов элементов
Console.WriteLine("массив с колличеством повторенний");
PrintArray(unuqArray);
