// Se//14.Напишите программу, которая определяет, является ли введенное
//пользователем число совершенным (сумма всех делителей числа равна
//самому числу).

Console.WriteLine("Введите число для проверки: ");
int num;
int.TryParse(Console.ReadLine(), out num);
int sumDev = 0;
for (int i = 1; i < num; i++)
{
    if (num % i == 0) sumDev += i;
}
if (num == sumDev) Console.WriteLine("Число " + num + " совершенное");
else Console.WriteLine("Число " + num + " не совершенное");