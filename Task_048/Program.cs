// Задача 46. Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.


Console.Clear();
int[,] CreateMatrixRndInt(int m, int n, int min, int max) // передает размер массива, заполняется и создается массив
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j; // вывод элементов по формуле m+n
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

int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 20);
PrintMatrix(arrayResult);


// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];

// void SumElemArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // номер строки 0 - количество строк
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // номер столбца 
//         {
//             matrix[i, j] = i + j;
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// SumElemArray(matrix);