Console.Clear();
Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine()!);
while (number > 0)
{
    int remains = number % 10;
    number /= 10;
    if (number > 0)
        Console.Write($"{remains}, ");
    else
        Console.Write(remains);
}