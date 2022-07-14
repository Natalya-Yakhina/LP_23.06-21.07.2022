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

int FillMatrix(int[,] arr)
{
int sum = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
if(i == j) sum += arr[i, j];
}
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

int[,] arrayCreate = CreateMatrixRndInt(5, 5);
PrintMatrix(arrayCreate);
Console.WriteLine();
Console.Write($"Сумма элементов главной диагонали матрицы --> {FillMatrix(arrayCreate)}");


// void FillArray(int[,] coll)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < coll.GetLength(0); i++)
//     {
//         for (int j = 0; j < coll.GetLength(1); j++)
//         {
//             coll[i, j] = rnd.Next(0, 11);
//         }
//     }
// }

// void PrintArray(int[,] coll)
// {
//     for (int i = 0; i < coll.GetLength(0); i++)
//     {
//         for (int j = 0; j < coll.GetLength(1); j++)
//         {
//             Console.Write(coll[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void Summ(int[,] coll)
// {
//     int summ = 0;
//     for (int i = 0; i < coll.GetLength(0); i++)
//     {
//         for (int j = 0; j < coll.GetLength(1); j++)
//         {
//             if (i == j) summ += coll[i, j];
//         }
//     }
//     Console.WriteLine(summ);
// }


// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Summ(matrix);