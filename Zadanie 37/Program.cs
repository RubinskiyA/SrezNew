// Создать класс для представления геометрической фигуры (например, прямоугольника) и методы для вычисления ее периметра и площади.

using Zadanie_37;

Console.Write("Введите длину прямоугольника:");
double x;
double.TryParse(Console.ReadLine(), out x);
Console.Write("Введите ширину прямоугольника:");
double y;
double.TryParse(Console.ReadLine(), out y);
Rectangle rectangle = new Rectangle(x,y);
double perimetr = rectangle.Perimetr();
double area = rectangle.Area();
Console.WriteLine($"Периметр прямоугольника: {perimetr}");
Console.WriteLine($"Площадь прямоугольника: {area}");
