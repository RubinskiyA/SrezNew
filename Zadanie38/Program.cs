//38.Реализовать класс для работы с числами и методы для выполнения
//арифметических операций.
using Zadanie38;

Console.Write("Введите первое число: ");
double x;
double.TryParse(Console.ReadLine(), out x);
Console.Write("Введите второе число: ");
double y;
double.TryParse(Console.ReadLine(), out y);
ArifmeticOper arifmetic = new ArifmeticOper();
char op;
Console.Write("Введите операцию: ");
char.TryParse(Console.ReadLine(), out op);
switch (op)
{
    case '+': Console.WriteLine(arifmetic.Add(x, y)); break;
    case '-': Console.WriteLine(arifmetic.Sub(x, y)); break;
    case '*': Console.WriteLine(arifmetic.Mult(x, y)); break;
    case '/':
        try { Console.WriteLine(arifmetic.Div(x, y)); }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;
    default: break;
}