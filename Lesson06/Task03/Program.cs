// Задайте произвольную строку. Выясните, является ли она палиндромом.

string ReversStr(string strLower)
{
    string newStr = string.Concat(strLower.ToArray().Reverse().ToArray());
    Console.WriteLine($"Перевёрнутое слово: {newStr}");
    return newStr;
}


Console.Clear();
string str = "Шалаш";
Console.WriteLine($"Проверяемое слово: {str}");
string strLower = str.ToLower();

if (strLower == ReversStr(strLower))
    Console.WriteLine($"Слово {str} является палиндромом");
else
    Console.WriteLine($"Слово {str} не является палиндромом");