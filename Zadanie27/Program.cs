// Создайте двумерный массив длиной 5х5 элементов, вручную
//заполните его числами от -10 до 10.
//Найти сумму элементов по диагонали матрицы

Random rnd = new Random();
int[,] mas = new int[5, 5];
for(int i = 0; i < mas.GetLength(0); i++)
{
    for(int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(-10, 11);
        Console.Write(mas[i,j]+" ");
    }
    Console.WriteLine();
}
int sum = 0;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (i == j) sum += mas[i, j];
    }
    
}
Console.WriteLine(sum);