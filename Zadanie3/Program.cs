// апишите программу, которая находит сумму двух чисел, введенных
//пользователем, и выводит результат на экран.
int x, y;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine(), out x);
Console.Write("Введите Второе число: ");
int.TryParse(Console.ReadLine(), out y);
Console.WriteLine($"{x} + {y} = {x + y}");
