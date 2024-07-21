// Реализовать локальную функцию для проверки, является ли число
//простым.

try
{
    int n;
    Console.Write("Введите число для проверки: ");
    int.TryParse(Console.ReadLine(), out n);
    if (n <= 0) throw new Exception("Введите число больше нуля.");
    if (IsPrime(n)) Console.WriteLine($"Число {n} явялется простым");
    else Console.WriteLine($"Число {n} не явялется простым");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

bool IsPrime(int n)
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

