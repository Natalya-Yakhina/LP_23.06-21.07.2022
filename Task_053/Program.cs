// Задача 53. Задайте двумерный массив. Напишите программу 
// которая поменяет местами первую и последнюю строку массива

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

void ArrayChangeFirstLastString(int[,] array)
{
    int lastString = array.GetLength(0) - 1;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[lastString, j];
        array[lastString, j] = temp;
    }
}

int[,] arrayResult = CreateMatrixRndInt(3,4,0,10);
PrintMatrix(arrayResult);
Console.WriteLine();
ArrayChangeFirstLastString(arrayResult);
PrintMatrix(arrayResult);
