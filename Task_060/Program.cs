// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] RandomArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    // int number = 10;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                    // array[i, j, k] = number++;
                    array[i, j, k] = rnd.Next(10, 99);
                    if(array[i, j, k] == array[i, j, k]) // проверка на уникальность числа (при маленьком диапозоне не работает)
                    {
                        array[i, j, k] = rnd.Next(10, 99);
                    }
            }
        }
    }
    return array;
}

void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] array = RandomArray(2, 2, 2);
PrintArray(array);