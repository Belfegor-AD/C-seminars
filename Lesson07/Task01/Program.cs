// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.


int NaturalNumbers(int m, int n){
    if (m == n)
        return m;
    Console.Write($"{m} ");
    return NaturalNumbers(m + 1, n);
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Ряд натуральных чисел от M до N: ");
if (m < n)
    Console.WriteLine(NaturalNumbers(m, n));
else
    Console.WriteLine(NaturalNumbers(n, m));