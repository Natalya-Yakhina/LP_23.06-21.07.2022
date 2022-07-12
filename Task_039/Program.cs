// Задача 39. Напишите программу которая перевернет
// одномерный массив (последний элемент будет на первом месте)
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -- [5 4 3 2 1]
// [6 7 3 6] -- [6 3 7 6]

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
Array.Reverse(array);
Console.WriteLine();
PrintArray(array);