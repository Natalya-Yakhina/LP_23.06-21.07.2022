// Задача 61. Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

int[,] TrianglePascal(int n)
{
    int[,] array = new int[n,n];
    for(int i = 0; i < n; i++)
    {
        array[i,0] = 1;
        array[i,i] = 1;
    }
    for (int j = 2; j < n; j++)
    {
    for (int k = 1; k < n; k++)
        {
            array[j, k] = array[j - 1, k - 1] + array[j - 1, k];
        }
    }
    return array;
}

void PrintIsoscelesTriangle(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j <= triangle.GetLength(1) - i; j++)
            Console.Write(" ");
        for (int k = 0; k <= i; k++)
        {
            Console.Write(" ");
            Console.Write(triangle[i, k]);
        }
        Console.WriteLine();
    }
}

PrintIsoscelesTriangle(TrianglePascal(5));



// Console.Clear();

// int n = InputNumbers("Введите количество строк: ");

// double[,] pascalTriangle = new double[n + 1, 2 * n + 1];

// FillPascalTriangle(pascalTriangle);

// Console.WriteLine();
// WriteArray(pascalTriangle);

// TransformationPascalTriangle(pascalTriangle);

// Console.WriteLine();
// WriteArray(pascalTriangle);

// void TransformationPascalTriangle(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     int count = 0;
//     for (int j = array.GetLength(1) - 1; j >= 0; j--)
//     {
//       if (array[i, j] != 0)
//       {
//         array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
//         array[i, j] = 0;
//         count++;
//       }
//     }
//   }
//   array[array.GetLength(0) - 1, 0] = 1;
// }

// void FillPascalTriangle(double[,] pascalTriangle)
// {
//   for (int k = 0; k < pascalTriangle.GetLength(0); k++)
//   {
//     pascalTriangle[k, 0] = 1;
//   }
//   for (int i = 1; i < pascalTriangle.GetLength(0); i++)
//   {
//     for (int j = 1; j < i + 1; j++)
//     {
//       pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
//     }
//   }
// }

// void WriteArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i, j] != 0)
//       {
//           Console.Write($"{array[i, j]} ");
//       }
//       else Console.Write("  ");
//     }
//     Console.WriteLine();
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }