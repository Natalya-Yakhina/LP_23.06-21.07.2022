// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибонначи: 0 и 1


Console.Write("Введите числo: ");
int num = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    Console.Write("0 1 ");
    for(int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write(array[i] + " ");
    }
}
Fibonacci(num);
