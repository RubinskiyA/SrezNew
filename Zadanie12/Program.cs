//Напишите программу, которая выводит строку введенную
//пользователем в обратном порядке.

Console.Write("Введите строку: ");
string str = Console.ReadLine()!;

string RevString(string text)
{
    string resText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        resText += text[i];
    }
    return resText;
}

Console.WriteLine(RevString(str));