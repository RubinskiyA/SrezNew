// 13. Напишите программу, которая определяет, является ли введенное пользователем число палиндромом (читается одинаково слева направо и справа налево).
Console.Write("Введите строку:");
string str=Console.ReadLine()!;
string reverse = "";
for (int i = str.Length - 1; i >= 0; i--) reverse += str[i];
if (str == reverse) Console.WriteLine("Палиндром");
else Console.WriteLine("Не палиндром");


