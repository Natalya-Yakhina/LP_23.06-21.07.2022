// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


// Задача 4: Заполните спирально массив 4 на 4.
// На выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] SnakeMatrix(int side)
{
    int[,] matrix = new int[side, side];
    int num = 1,
        column = side,
        row = side,
        zeroColumn = 0,
        zeroRow = 0;
    while (zeroColumn < column)
    {
        for (int i = zeroColumn; i < column; i++)
        {
            matrix[zeroRow, i] = num++;
        }
        column --;
        for (int j = zeroRow + 1; j < row; j++)
        {
            matrix[j, row - 1] = num++;
        }
        row --;
        for (int k = column - 1; k >= zeroColumn; k--)
        {
            matrix[column, k] = num++;
        }
        for (int l = row - 1; l > zeroRow; l--)
        {
            matrix[l, zeroColumn] = num++;
        }
        zeroColumn++;
        zeroRow++;
    }
    return matrix;
}

PrintMatrix(SnakeMatrix(4));