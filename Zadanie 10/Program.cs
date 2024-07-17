//10. Напишите программу, которая находит среднее арифметическое трех чисел, введенных пользователем, и выводит результат на экран.
Console.Write("Введите первое число:");
int x=int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число:");
int z = int.Parse(Console.ReadLine()!);
Console.WriteLine("Среднее арифметическое трех чисел: " +(x+y+z)/3);
