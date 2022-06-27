// 14. Напишите программу которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 - нет
// 46 - нет
// 161 - да

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 7 == 0) && (a % 23 == 0)) Console.WriteLine($"Число {a} кратно 7 и 23");
else Console.WriteLine($"Число {a} не кратно 7 и 23");
// string result = a % 7 % 23 == 0 ? $"Число {a} кратно 7 и 23" : $"Число {a} не кратно 7 и 23";
// Console.WriteLine(result);
