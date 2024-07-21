Random random = new Random();
int[,] mas = new int[5, 5];
for  (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(-10, 11);
        Console.Write(mas[i,j]+" ");
    }
    Console.WriteLine();
}

for  (int k = 0; k < mas.GetLength(0); k++)
{
    int sum = 0;
    for (int h = 0;  h < mas.GetLength(1); h++)
    {
        sum += mas[k, h];
    }
        Console.WriteLine("Сумма "+(k+1)+" строки = "+sum+" ");
}