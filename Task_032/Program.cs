// 31. 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9]
// 2. Найдите сумму отрицательных и положительных элементов массива
// 3. Вывод результата
// Например в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, - 1, 6]

int[] CreateArrayRnd(int size, int min, int max) // передает размер массива, заполняется и создается массив
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr; // записывает в переменную array
}

int[] GetSumPosNegElem(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
        {
            sumNeg = sumNeg + arr[i];
            sumNeg += arr[i];
        }
        else
        {
            sumPos += arr[i];
        }

    }
    return new int[]{ sumPos, sumNeg };
}
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if ( i == 0 ) Console.Write("[");
        if ( i < arr.Length - 1 ) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] array = CreateArrayRnd(12, -9, 9); // нам нужен массив и диапозон
PrintArray(array);