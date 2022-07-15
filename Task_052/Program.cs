// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        if (j == 0) Console.Write("|");
        if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 4} | ");
        else Console.Write($"{arr[i, j], 4} | ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sumG = 0;
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            sumG = sumG + arr[j, i];
        }
        sumG = sumG / arr.GetLength(0); 
        Console.WriteLine($"Среднее арифметическое столбца №{i+1} = {Math.Round(sumG, 1)}"); // сокращение
}
}
int[,] arrayResult = CreateMatrixRndInt(3,4,0,10);
PrintMatrix(arrayResult);
ArithmeticMeanArray(arrayResult);