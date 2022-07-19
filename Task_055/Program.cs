// Задача 55. Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(5, 11);
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

int[,] ExchangeMatrix(int[,] array) // метод создание нового массива
{
    int[,] arr = new int[array.GetLength(1), array.GetLength(0)]; // размер нового массива равен размеру предыдущего
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[j, i] = array[i, j]; // цифра столбца меняется на цифру строки
        }
    }
    return arr;
}

int[,] arrayResult = CreateMatrixRndInt(4,4);
PrintMatrix(arrayResult);
Console.WriteLine();
if(arrayResult.GetLength(0) != arrayResult.GetLength(1)) Console.WriteLine("Невозможно заменить строку на столбец");
else
{
    int[,] resultArray = ExchangeMatrix(arrayResult);
    PrintMatrix(resultArray);
}
