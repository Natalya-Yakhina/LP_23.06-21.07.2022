// 30. Напишите программу, которая выводит массив из 8 'ktvtynjd? pfgjkytyysq yekzvb b tlbybwfvb d ckexfqyjv gjhzlrt
// [1, 0, 1, 1, 0, 1, 0, 0]


// 1 СПОСОБ:
// int[] array = new int[8]; //7
// Console.WriteLine(array[7]);

// void FillArray(int[] collection) // заполняет массив
// {
//     int index = 0;
//     while(index < collection.Length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// } 

// void PrintArray (int[] collection) // выводит на печать
// {
//     int index = 0;
//     Console.Write("[ ");
//     while(index < collection.Length)
//     {
//         Console.Write($"{collection[index]} ");
//         index++;
//     }
//     Console.Write("]");
// }
// FillArray(array);
// PrintArray(array);


// 2 СПОСОБ:

int[] array = new int[8]; //7
Random rand = new Random(); // отдельно создаем 
Console.Write("[");
for (int i = 0; i < 8; i++)
{
    array[i] = rand.Next(0,2); // задаем некст
    Console.Write(array[i] + ",");
}
Console.Write("]");