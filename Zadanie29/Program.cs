//29.Найти среднее арифметическое для каждого подмассива.

Random random = new Random();
int[][] mas = new int[5][];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new int[random.Next(5, 16)];
}
for (int i = 0; i < mas.Length; i++)
{
    int sum = 0;
    for (int j = 0; j < mas[i].Length; j++)
    {
        mas[i][j] = random.Next(10, 100);
        sum+= mas[i][j];
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine($"Среднее арифметическое значение {i+1} элемента массива - {sum / mas[i].Length}");
    Console.WriteLine();
}


