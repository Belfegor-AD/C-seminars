Console.Clear();
Console.Write("Введите целое число от 10 до 99: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 10 && number <= 99)
    if (number / 10 > number % 10)
        Console.WriteLine("1я цифра больше 2й");
    else
        if (number / 10 < number % 10)
            Console.WriteLine("2я цифра больше 1й");
        else
            Console.WriteLine("Цифры равны");
else
    Console.WriteLine("Не верное число");