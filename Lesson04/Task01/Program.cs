// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
Console.Clear();
string number = " ";
while (Exit(number))
{
    Console.WriteLine("Еще попытка.");
}

bool Exit(string num)
{
    Console.Write("Введите целое число или 'q': ");
    num = Console.ReadLine()!;
    if (num == "q")
        return false;
    int sum = 0;
    for(int i = 0; i < num.Length; i++)
    {
        int m = int.Parse(num[i].ToString());
        sum = sum + m;
    }
    Console.Write($"Сумма цифр: {sum}");
    if (sum % 2 == 0)
    {
        Console.WriteLine(" чётная");
        return false;
    }
    Console.WriteLine(" не чётная");
    return true;
}
    
