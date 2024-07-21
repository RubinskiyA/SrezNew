// Посчитать количество четных чисел в массиве
Random random = new Random();
int[] mas = new int[8];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(-10, 11);
}
foreach (int n in mas) Console.Write(n + " ");
int count=0;
foreach (int n in mas)
{
    if (n % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {count}");


