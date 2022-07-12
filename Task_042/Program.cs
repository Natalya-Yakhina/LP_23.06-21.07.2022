// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 ---> 101101
// 3 ---> 11
// 2 ---> 10

// ======= решение с помощью цикла ===========
// универсальный алгоритм перевода во все системы счисления //

// Console.Write("Введите целое числo: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Введите основание системы счисления: ");
// int baseNum = int.Parse(Console.ReadLine()); // система счисления

// int d10 = 1;
// int result = 0;
// while(number != 0)
// {
//     result = result + number %  baseNum *d10;
//     number = number / baseNum; 
//     d10 = d10 * 10;
// }
// Console.WriteLine(result);

// ======= решение через рекурсию ===========

int a = 13; //чтобы получить универсальную систему
void ToBin(int n) // int baseNum
{
    if(n == 0) return;
    ToBin(n / 2); // n / baseNum, baseNum
    Console.Write(n % 2); // n % baseNum 
}
ToBin(a); // сразу выводит результат //а, 2

// -------------------------------------------------
// Console.Write("Введите числo: ");
// int num = int.Parse(Console.ReadLine());

// int Base10to2(int n)
// {
//     if(n == 1) return 1;
//     if(n == 0) return 0;
//     return n % 2 + 10 * Base10to2(n/2);
// }

// // Base10to2(num);
// Console.WriteLine(Base10to2(num));

// -------------------------------------------------
// Console.Write("Введите числo: ");
// int num = Convert.ToInt32(Console.ReadLine());

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


// -------------------------------------------------
// Console.Write("Введите числo: ");
// int num = Convert.ToInt32(Console.ReadLine());
// void Base10to2(int num1)
// {
//     int a = 0;
//     int i = 0;

//     int[] b = new int[10];
//     while (num1 >= 1)
//     {
//         a = num1 % 2;
//         i++;
//         num1 = num1 / 2;
//         // Reverse(a);
//         Console.Write(a);
//     }
// }
// Base10to2(num);