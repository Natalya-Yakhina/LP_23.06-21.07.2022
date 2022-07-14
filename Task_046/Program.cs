// Задача 46. Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами. m = 3, n = 4

// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// создаем двумерный массив

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n, int min, int max) // передает размер массива, заполняется и создается массив
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
        if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} | ");
        else Console.Write($"{arr[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}
int[,] arrayResult = CreateMatrixRndInt[3, 4, -5, 5];
PrintMatrix(arrayResult);

//===========================================================
// void FillPrintArray(int[,] coll)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < coll.GetLength(0); i++)
//     {
//         for (int j = 0; j < coll.GetLength(1); j++)
//         {
//             coll[i, j] = rnd.Next(-10, 11);
//             Console.Write(coll[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];
// FillPrintArray(matrix);

//==================================================================================
// void RandomArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-99, 100);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
