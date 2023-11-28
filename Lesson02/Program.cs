Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine($"{number} кратно 7 и 23");
else
    Console.WriteLine($"{number} не делится без остатка на 7 и 23");