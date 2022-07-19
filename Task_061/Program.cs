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