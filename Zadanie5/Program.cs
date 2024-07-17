//5.Напишите программу, которая находит наибольшее число из трех
//введенных пользователем чисел и выводит его на экран.

Console.WriteLine("Введите первое число: ");
int num1;
int.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("Введите второе число: ");
int num2;
int.TryParse(Console.ReadLine(), out num2);
Console.WriteLine("Введите третье число: ");
int num3;
int.TryParse(Console.ReadLine(), out num3);
int maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;
Console.WriteLine(maxNum + " - наибольшее из введенных чисел");
