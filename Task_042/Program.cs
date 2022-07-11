// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 3 ---> 11
// 2 ---> 10

// void Base10to2(int num)
// {
//     string number =  " ";
//     while(num > 0)
//     {
//         number = num % 2 + number;
//         num /= 2;
//     }
//     Console.WriteLine(number);
// }
Console.Write("Введите числo: ");
int num = Convert.ToInt32(Console.ReadLine());
Base10to2(num);


void Base10to2(int num1)
{
    int a = 0;
    int i = 0;

    int[] b = new int[10];
    while (num1 >= 1)
    {
        a = num1 % 2;
        b[i] = a;
        i++;

        num1 = num1 / 2;

        Console.Write(a);
    }
}
Base10to2(num);