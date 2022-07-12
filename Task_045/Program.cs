// 45. Напишите программу которая будет создавать копию 
// заданного массива с помощью поэлементного копирования

Console.Clear();

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

int[] CopyArray(int[] arr)
{
    int size = arr.Length;
    int[] newArr = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i];
        // if(i == 1) newArr[i] = 2213;
    }
    return newArr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

int[] array = CreateArrayRnd(5, -5, 5);
PrintArray(array);
int[] newArr = CopyArray(array);
PrintArray(newArr);