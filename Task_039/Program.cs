// Задача 39. Напишите программу которая 
// одномерный массив (последний элемент)
// месте,
//[1, 2, 3, 4, 5]

// int[] array = new int[8];
// Array.Reverse(array);

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

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if ( i == 0 ) Console.Write("[");
        if ( i < arr.Length - 1 ) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
// разворот массива
//[1, 2, 3, 4, 5]
void Reverse(int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size-1;
    while(index1 < index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
        index1 ++;
        index2 --;
    }
}

int[] array = CreateArrayRnd(5, 1, 9);
PrintArray(array);
Reverse(array);
Console.WriteLine();
PrintArray(array);