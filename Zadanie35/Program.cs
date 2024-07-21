//35.Написать локальную функцию для вычисления факториала числа.
long Factorial(int n)
{
    if (n == 0) return 1;
    else return n * Factorial(n - 1);
}
Console.Write("Введите n: ");
int n;
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine($"Факториал {n} равен {Factorial(n)}");