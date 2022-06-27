// 9. Напишите программу, которая выводит случайное число из отрезка [10 99] 
// и показывает наибольшую цифру числа
// 78 --> 8
// 12 --> 2
// 85 --> 8

int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {rndNum}");

int firstDigit = rndNum / 10;
int secondDigit = rndNum % 10; 
if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа: {rndNum} => {firstDigit}");
else if (firstDigit < secondDigit) Console.WriteLine($"Наибольшая цифра числа: {rndNum} => {secondDigit}");
else Console.WriteLine($"Цифры числа {rndNum} равны");