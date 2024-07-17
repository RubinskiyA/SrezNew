// Напишите программу, которая находит наименьшее общее кратное
//двух чисел, введенных пользователем, и выводит результат на экран.
int x, y;
try
{
    Console.Write("Введите первое число: ");
    int.TryParse(Console.ReadLine(), out x);
    Console.Write("Введите второе число: ");
    int.TryParse(Console.ReadLine(), out y);
    if (x == 0 || y == 0) throw new Exception("Введите число, не равное нулю");
    for (int i = Math.Max(x, y); i < i + 1; i++)
    {
        if (i % x == 0 && i % y == 0)
        {
            Console.WriteLine($"Наименьшее общее кратное чисел {x} и {y} - число {i}");
            break;
        }
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

