//23.Определить наибольший и наименьший элемент в массиве.

Random random = new Random();int[] mas = new int[8];for (int i = 0; i < mas.Length; i++){    mas[i] = random.Next(-10, 11);}foreach (int n in mas) Console.Write(n + " ");int maxValue = int.MinValue;int minValue=int.MaxValue;for (int  j = 0;  j < mas.Length;  j++)
{
    if (mas[j] > maxValue) maxValue = mas[j];
    if (mas[j] < minValue) minValue = mas[j];
}
Console.WriteLine();
Console.WriteLine("Максимальное значение - "+maxValue+", минимальное значение - "+minValue);