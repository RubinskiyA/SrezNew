// 13. Напишите программу, которая определяет, является ли введенное пользователем число палиндромом (читается одинаково слева направо и справа налево).
Console.Write("Введите строку:");
string word=Console.ReadLine()!;
string reverse = "";
for (int i = word.Length - 1; i > 0; i--) reverse += word[i];
if (word == reverse) Console.WriteLine("Палиндром");
else Console.WriteLine("Не палиндром");


