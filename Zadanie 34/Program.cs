//Написать локальную функцию для проверки, является ли строка палиндромом

class Program
{
    static void Main()
    {
        Console.Write("Введите строку:");
        string stroka = Console.ReadLine()!;
        bool IsPalindrom(string str)
        {
            str = str.Replace(" ", "").ToLower();
            char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);
            return str == new string(reverse);
        }
        if (IsPalindrom(stroka))
        {
            Console.WriteLine("Строка является палиндромом");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом");
        }
    }
}

