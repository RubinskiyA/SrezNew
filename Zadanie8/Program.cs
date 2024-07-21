//8.Напишите программу, которая считывает строку с клавиатуры и выводит
//на экран количество символов в этой строке.

Console.WriteLine("Введите строку: ");
string? str = Console.ReadLine();
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] != ' ') count++;

}
Console.WriteLine(count + " символов в строке");
