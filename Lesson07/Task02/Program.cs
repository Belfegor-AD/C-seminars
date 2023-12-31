﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n


int Akkerman(int m, int n){
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Clear();
Console.WriteLine("Функция Аккермана(m, n).");
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Akkerman(m, n));