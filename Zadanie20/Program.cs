//20.Создайте одномерный массив длиной 8 элементов, вручную
//заполните его числами от -10 до 10.


Random random = new Random();
int[] mas = new int[8];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(-10,11);
}
foreach (int n in mas) Console.Write (n+" "); 

