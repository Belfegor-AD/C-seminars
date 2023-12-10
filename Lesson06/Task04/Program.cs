// Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.


string ReverseStr (string str)
{
    return string.Join(" ", str.Split().Reverse().ToArray());;
}

Console.Clear();
string str = "Hello my world";
Console.WriteLine($"Первоначальная строка: {str}");
Console.WriteLine($"Перевернутая строка: {ReverseStr(str)}");