// 9. Напишите программу, которая выводит случайное число из отрезка [10 99] 
// и показывает наибольшую цифру числа
// 78 --> 8
// 12 --> 2
// 85 --> 8

int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {rndNum}");

int firstDigit = rndNum / 10;
int secondDigit = rndNum % 10; 

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //тернарный оператор может возвращать значение и записвать в переменную (? - тогда if, : если else)
// int maxDigit = firstDigit;
// if(secondDigit > maxDigit) maxDigit = secondDigit;
// else if (secondDigit == maxDigit) maxDigit = 0;

if(maxDigit > 0) Console.WriteLine($"Наибольшая цифра числа: {rndNum} => {maxDigit}");
else Console.WriteLine($"Цифры числа {rndNum} равны");