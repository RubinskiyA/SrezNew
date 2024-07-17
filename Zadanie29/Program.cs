Random random = new Random();
int[][] mas = new int[5][];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new int[random.Next(5, 16)];
}
for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
        mas[i][j] = random.Next(10, 100);
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
