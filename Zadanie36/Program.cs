// Создать локальную функцию для нахождения наибольшего общего
//делителя двух чисел.

try
{
    int x, y;
    Console.Write("Введщите первое число: ");
    int.TryParse(Console.ReadLine(), out x);
    Console.Write("Введщите второе число: ");
    int.TryParse(Console.ReadLine(), out y);
    if (x == 0 || y == 0)
    {
        throw new Exception("Введите число не равное нулю");
    }
    else Console.WriteLine($"Наибольший общий делитель чисел {x} и {y} - число {MaxDivider(x,y)}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

int MaxDivider(int x, int y)
{
    int MaxDiv = 1;
    for (int i=1; i<=Math.Min(x,y); i++)
    {
        if(x%i == 0 && y % i == 0)
        {
            MaxDiv = i;
        }
    }
    return MaxDiv;
}
