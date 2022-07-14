// Задача 49. Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
            arr[i, j] = new Random().Next(1, 10);
            }
        }
        return arr;
}

int[,] FillMatrix2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i+= 2)
        {
            for (int j = 0; j < arr.GetLength(1); j+= 2)
            {
                arr[i, j] = arr[i, j] * arr[i, j];
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
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} | ");
            else Console.Write($"{arr[i, j], 3} | ");
        }
    Console.WriteLine();
    }
}

int[,] arrayCreate = CreateMatrixRndInt(3, 4);
PrintMatrix(arrayCreate);
Console.WriteLine();
int[,] arrayResult = FillMatrix2(arrayCreate);
PrintMatrix(arrayCreate);