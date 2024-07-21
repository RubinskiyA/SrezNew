// Создать массив массивов
//Поменять местами строки в подмассивах.


int[][] mas = new int[][]
{
    new int[] { 7, -4, 22, 12 },
    new int[] { 1},
    new int[] { 13, -20, -6, -9 },
    new int[] { 0, 16, 5 }
}; 
//Вывод массива.
for(int i = 0; i < mas.Length; i++)
{
    for(int j=0;j < mas[i].Length; j++)
    {
        Console.Write(mas[i][j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите номера строк для обмена местами: ");
int x, y;
Console.Write("введите номер первой строки: ");
int.TryParse(Console.ReadLine(), out x);
Console.Write("Введите номер второй строки: ");
int.TryParse(Console.ReadLine(), out y);
int[] temp = mas[x-1];
mas[x-1] = mas[y-1];
mas[y-1] = temp;
for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}

//Случайное перемешивание :

//Random rnd=new Random();
//int[][]mas2=new int[mas.Length][];
//int[] nums = new int[] { 0, 1, 2, 3 };
////Перемешивание элементов массива nums.
//for (int j = nums.Length - 1; j > 0; j--)
//{
//    int k = rnd.Next(0, j + 1);
//    int temp = nums[j];
//    nums[j] = nums[k];
//    nums[k] = temp;
//}
////Перемешивание строк массива.
//for (int i=0;i< mas2.Length; i++)
//{
//    mas2[i] = mas[nums[i]];
//}
//Console.WriteLine();
////Вывод перемешанного массива.
//for (int i = 0; i < mas2.Length; i++)
//{
//    for (int j = 0; j < mas2[i].Length; j++)
//    {
//        Console.Write(mas2[i][j] + " ");
//    }
//    Console.WriteLine();
//}