// 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Cлучайное трехзначное число из отрезка 100-999 => {rndNum}");
int newNum(int num)
{
    int firstNum = num /100;
    int secondNum = num % 10;
    return firstNum *10 + secondNum;
}
int result = newNum(rndNum);
Console.WriteLine($"Получившееся двухзначное число => {result}");
// int newNum = rndNum / 100 * 10 + rndNum%10;

