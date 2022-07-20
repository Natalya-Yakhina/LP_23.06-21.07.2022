// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int m, int n) // задаем двумерный массив
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
            matrix[i, j] = new Random().Next(1, 10);
            }
        }
        return matrix;
}

void PrintMatrix(int[,] matrix) // печать двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (j == 0) Console.Write("|");
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3} | ");
        else Console.Write($"{matrix[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

int[] FindSumElemStringMatrix(int[,] matrix) // метод поиска суммы элементов строки массива через одномерный
{
    int[] sumElem = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElem[i] = sumElem[i] + matrix[i, j];
        }
    }
    return sumElem;
}

void PrintSumElemStringMatrix(int[] sumElem) // вывод суммы элементов по строкам на печать
{
    for (int i = 0; i < sumElem.Length; i++)
    {
        Console.WriteLine($"Сумма элементов строки {i + 1} = {sumElem[i]} ");
    }
}

void FindMinSumString(int[] sumElem) // поиск индекса строки с минимальной суммой элементов
{
    int minSumElem = sumElem[0];
    int minIndex = 0;
    for (int i = 0; i < sumElem.Length; i++)
    {
        if (minSumElem > sumElem[i])
        {
            minSumElem = sumElem[i];
            minIndex = i;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + $"{minIndex + 1}");
}

int[,] in_matrix = CreateMatrixRndInt(5, 5);
PrintMatrix(in_matrix);
Console.WriteLine();

int[] matrixResult = FindSumElemStringMatrix(in_matrix);
PrintSumElemStringMatrix(matrixResult);
Console.WriteLine();

FindMinSumString(matrixResult);
