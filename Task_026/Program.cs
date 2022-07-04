// 26. Напишите программу которая на вход принимает число и выдает количество цифр в числе
// 456 - 3
// 78 - 2
// 89126 - 5

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 0;
while(num > 0)
{
    i++;
    num = num / 10;
}
Console.WriteLine("Количество цифр в введенном числе: {0}", i);
