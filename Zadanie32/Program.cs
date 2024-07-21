int Multi(int x, int y)
{
    return x * y;
}
Console.WriteLine("Введите первое число: ");
int num1, num2;
int.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("Введите второе число: ");
int.TryParse(Console.ReadLine(), out num2);
Console.WriteLine($"Произведение чисел {num1} и {num2} равно {Multi(num1, num2)}");