﻿//23.Определить наибольший и наименьший элемент в массиве.

Random random = new Random();
{
    if (mas[j] > maxValue) maxValue = mas[j];
    if (mas[j] < minValue) minValue = mas[j];
}
Console.WriteLine();
Console.WriteLine("Максимальное значение - "+maxValue+", минимальное значение - "+minValue);