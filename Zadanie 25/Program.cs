﻿//Создайте двумерный массив длиной 5х5 элементов, вручную заполните его числами от -10 дo 10
int[,]mas=new int[5,5]
{
    { -10, -5, 0, 5, 10 },
    { -9,  -3, 4, 0,  2 },
    { -8,   6, 8, 3, -4 },
    { -7,   7, 9, 1, -1 },
    { -6,  -2, 3, -3, 0 }
};

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}