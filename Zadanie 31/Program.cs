//31 Найти наибольший и наименьший элементы в каждом подмассиве.
int[][] mas = new int[4][];
{
    mas[0] = new int[] { 7, -4, 22, -12 };
    mas[1] = new int[] { 1 };
    mas[2] = new int[] { 13, -20, -6, -9 };
    mas[3] = new int[] { 0, 16, 5 };
}

for (int i = 0; i < mas.Length; i++)
{
    int max=int.MinValue;
    int min = int.MaxValue;
    for (int j = 0; j < mas[i].Length; j++)
    {
        Console.Write(mas[i][j] + " ");
        if (mas[i][j] > max)
        {
            max = mas[i][j];
        }
        if (mas[i][j] <min)
        {
            min = mas[i][j];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Наибольшее число: "+ max);
    Console.WriteLine("Наименьшее число: " + min);
}
