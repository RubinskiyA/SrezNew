// Напишите программу, которая находит все простые числа от 1 до 100
//и выводит их на экран.

int n;
void SimpNums(int n)
{
    int count = 0;
    for (int i = 1; i <= n; i++)
    {
        if (IsSimple(i)) Console.WriteLine(i);
    }
}
bool IsSimple(int n)
{
    if (n == 1) return false;
    if (n == 2) return true;
    int k = 0;
    for (int i = 2; i <= n; i++)
    {
        if (n % i == 0) k++;
    }
    if (k == 1) return true;
    else return false;
}
SimpNums(100);