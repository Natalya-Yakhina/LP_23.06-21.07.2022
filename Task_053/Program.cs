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

// ========= 1 ==========
// void ArrayChangeFirstLastString(int[,] array)
// {
//     int lastString = array.GetLength(0) - 1;
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[0, j];
//         array[0, j] = array[lastString, j];
//         array[lastString, j] = temp;
//     }
// }

// ========= 2 ==========
// void ArraySwap(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         //Console.WriteLine("Матрица неверного размера");
//     }
//     else
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
//             }
//         }
//     }
// }

// ====== 3 ======
void ExchargeArray(int[,] array)
{
    int temp = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0, j]; // записываем значение верхней строки
        array[0, j] = array[array.GetLength(0) - 1, j]; // в верхнюю строку записываем нижнюю
        array[array.GetLength(0) - 1, j] = temp; // нижнюю строку записываем из временного хранения верхней строки
    }
}

int[,] arrayResult = CreateMatrixRndInt(3,4,0,10);
PrintMatrix(arrayResult);
Console.WriteLine();
// ArrayChangeFirstLastString(arrayResult); // 1
// ArraySwap(arrayResult); // 2
// if (arrayResult.GetLength(0) != arrayResult.GetLength(1))
// {
//     Console.WriteLine("Матрица неверного размера");
// }
// else
// {
//     PrintMatrix(arrayResult);
// }
ExchargeArray(arrayResult);
PrintMatrix(arrayResult);

