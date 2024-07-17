// Напишите программу, которая вычисляет факториал введенного
//пользователем числа и выводит результат на экран;

int n;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out n);
int Fact(int n)
{
    if (n == 1) return 1;
    else return n * Fact(n - 1);
}
Console.WriteLine($"Факториал числа {n} = {Fact(n)}"); ;