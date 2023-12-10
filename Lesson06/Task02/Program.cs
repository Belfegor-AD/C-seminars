// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Clear();
string str = "Hello World";
Console.WriteLine($"Изначальная строка: {str}");
string strLower = str.ToLower();

Console.WriteLine($"Итоговая строка: {strLower}");