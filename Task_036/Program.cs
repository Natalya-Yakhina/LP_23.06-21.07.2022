// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

void FillArray(int[] arr) // ввод массива
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = rnd.Next(-10, 90);
    }
}

void PrintArray(int[] arr) // вывод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

int SumNeChet(int[] arr) // метод вычисления суммы значений элементов массива на нечетных позициях
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum += arr[i];  // != не равно
    }
    return sum;
    // Console.WriteLine($"Сумма элементов нечетных позиций = {sum}");
}

FillArray(array);
PrintArray(array);
//SumNeChet(array);

int sum = SumNeChet(array);
Console.WriteLine($"Сумма элементов нечетных позиций = {sum}");
