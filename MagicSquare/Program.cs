//Написать метод проверяющий, является ли данный числовой массив -
//магическим квадратом и возвращающий true если это так и false в
//противном случае.

int[,] square =
{
    { 2, 7, 6 },
    { 9,5,1},
    { 4,3,8}
};

bool IsMagic(int[,] square)
{
    //проверка массива на "квадратность"
    if(square.GetLength(0)!= square.GetLength(1))
    {
        return false;
    }
    //Инициализция массива сумм квадрата.
    int[] masSum = new int[square.GetLength(0) * 2 + 2];
    //подсчет сумм элементов в каждой строке
    for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            masSum[i] += square[i, j];
        }
    }
    //подсчет сумм элементов в каждом столбце
    for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            masSum[square.GetLength(0) + i] += square[j, i];
        }
    }
    //вычисление сумм диагоналей
    for (int i = 0; i < square.GetLength(0); i++)
    {
        masSum[square.GetLength(0) * 2] += square[i, i];
        masSum[square.GetLength(0) * 2 + 1] += square[i, square.GetLength(0) - 1 - i];
    }
    //Для удобства проверки работы, вывод всех сумм в консоль.
    for (int i = 0; i < masSum.Length; i++)
    {
        Console.Write(masSum[i] + " ");
    }
    //Проверка равенства всех сумм.
    bool isMagic = true;
    for (int i = 0; i <masSum.Length-2; i++)
    {
        if (masSum[i] != masSum[i + 1])
        {
            isMagic = false;
            break;
        }
    }
    return isMagic;
}
Console.WriteLine(IsMagic(square));
