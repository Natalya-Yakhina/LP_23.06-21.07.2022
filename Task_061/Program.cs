// Задача 61. Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

// int[,] TrianglePascal(int n)
// {
//     int[,] array = new int[n,n];
//     for(int i = 0; i < n; i++)
//     {
//         array[i,0] = 1;
//         array[i,i] = 1;
//     }
//     for (int j = 2; j < n; j++)
//     {
//     for (int k = 1; k < n; k++)
//         {
//             array[j, k] = array[j - 1, k - 1] + array[j - 1, k];
//         }
//     }
//     return array;
// }

// void PrintIsoscelesTriangle(int[,] triangle)
// {
//     for (int i = 0; i < triangle.GetLength(0); i++)
//     {
//         for (int j = 0; j <= triangle.GetLength(1) - i; j++)
//             Console.Write(" ");
//         for (int k = 0; k <= i; k++)
//         {
//             Console.Write(" ");
//             Console.Write(triangle[i, k]);
//         }
//         Console.WriteLine();
//     }
// }

// PrintIsoscelesTriangle(TrianglePascal(5));

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
int [,] CreateTriangle (int size)
{
    int [,] triangle = new int [size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i,0] = 1;
        triangle[i,i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle [i,j] = triangle [i-1, j-1] + triangle [i-1,j];
        }
    }
PrintMatrix (triangle);
return triangle;
}
CreateTriangle (5);

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}