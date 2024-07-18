// 19.Напишите программу, которая считывает числа с клавиатуры, пока пользователь не введет отрицательное число, и выводит сумму
//введенных положительных чисел на экран.
class Program
{
    static void Main()
    {
        int sum = 0;

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine()!;

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                continue;
            }

            if (number < 0)
            {
                break;
            }

            sum += number;
        }

        Console.WriteLine("Сумма введенных положительных чисел: " + sum);
    }
}