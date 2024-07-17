// Напишите программу, которая проверяет, является ли введенное
//пользователем число простым (имеет только два делителя - 1 и само
//число).

int n;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out n);

bool IsSimple(int n)
{
    if (n == 1) return false;
    if (n == 2) return true;
    int k = 0;
    for (int i = 2; i <= n; i++)
    {
        if (n % i == 0) k++;
    }
    if (k == 1) return true;
    else return false;
}
if (IsSimple(n)) Console.WriteLine($"Число {n} является простым.");
if (!IsSimple(n)) Console.WriteLine($"Число {n} не является простым.");