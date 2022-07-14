// // Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.)

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
// --------------первый способ--------------------
// int FillMatrix(int[,] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(i == j) sum += arr[i, j];
//         }
//     }
//     return sum;
// }

// --------------второй способ--------------------
int FillMatrix(int[,] arr)
{
    int sum = 0;
    int index = 0;
    if(arr.GetLength(0) > arr.GetLength(1)) index = 1;
    for (int i = 0; i < arr.GetLength(index); i++)
    {
        sum += arr[i, i];
    }
    return sum;
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

int[,] arrayCreate = CreateMatrixRndInt(3, 6);
PrintMatrix(arrayCreate);
Console.WriteLine();
Console.Write($"Сумма элементов главной диагонали матрицы --> {FillMatrix(arrayCreate)}");