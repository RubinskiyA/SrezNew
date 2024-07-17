// Проверить, является ли массив “палиндромом”.
//Да да, числовой массив.

Random rnd = new Random();
int[] mas = new int[8];
//Задаем массив случайных чисел.
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(-10, 11);
    Console.Write(mas[i] + " ");
}
int lastIndex = mas.Length - 1;
IsPalindrom(mas, 0, lastIndex);
Console.WriteLine();

//Задаем массив, который точно палиндром.
int[] mas2 = { 1, 2, 3, 4, 4, 3, 2, 1 };
int lastIndex2 = mas2.Length - 1;
for (int i = 0; i < mas2.Length; i++)
{
    Console.Write(mas2[i] + " ");
}
IsPalindrom(mas2, 0, lastIndex2);

void IsPalindrom(int[] mas, int curIndex, int lastIndex)
{
    if (mas[curIndex] != mas[lastIndex])
    {
        Console.WriteLine("Not a palindrom");
        return;
    }
    else if (curIndex >= lastIndex)
    {
        Console.WriteLine("Is a palindrom");
        return;
    }
    IsPalindrom(mas, curIndex + 1, lastIndex - 1);
}


