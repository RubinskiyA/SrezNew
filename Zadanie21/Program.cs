//Создайте одномерный массив длиной 8 элементов, вручную
//заполните его числами от -10 до 10.
//Найти сумму элементов в массиве.
Random rnd = new Random();
int[] mas = new int[8];
int sum = 0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(-10, 11);
    sum += mas[i];
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива: {sum}");
