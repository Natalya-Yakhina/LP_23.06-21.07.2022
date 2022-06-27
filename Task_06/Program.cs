// 16. Напишите программу которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string result = a % 7 % 23 == 0 ? $"Число {a} кратно 7 и 23" : $"Число {a} не кратно 7 и 23";
Console.WriteLine(result);
