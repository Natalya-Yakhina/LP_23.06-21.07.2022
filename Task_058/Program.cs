// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndIntA(int m, int n) // метод ввода матрицы
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // метод печати двумерного массива
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

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB) // метод произведения двух матриц
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i,j] = 0; 
            for(int k = 0; k < matrixB.GetLength(1); k++)
            {
                matrixC[i, j] =  matrixC[i, j] + matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

int[,] matrixA = CreateMatrixRndIntA(2, 2);
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndIntA(2, 2);
PrintMatrix(matrixB);
Console.WriteLine($"Результирующая матрица: ");
int[,] matrixC = MultiplicationMatrix(matrixA, matrixB);
PrintMatrix(matrixC);