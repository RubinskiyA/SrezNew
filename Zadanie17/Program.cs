//17.Напишите программу, которая проверяет, является ли введенное
//пользователем слово панграммой (содержит все буквы алфавита).
string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
Console.WriteLine("Введите строку для проверки: ");
string? str=Console.ReadLine();
int count = 0;
for (int i=0; i<str.Length; i++)
{
    for (int j = 0; j < alphabet.Length; j++)
    {
        if (str.ToLower().Contains(alphabet[j])) count++;
    }
    break;
}
Console.WriteLine(str.ToLower());
if (count >= 33) Console.WriteLine("Строка панграмма");
else Console.WriteLine("Строка не панграмма");
