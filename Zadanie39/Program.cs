// Написать класс для управления банковским счетом с методами для
//пополнения и снятия средств.


using Zadanie39;

decimal curBalance = 0;
BankAccount bankAccount = new BankAccount();
bool program = true;
do
{
    Console.Clear();
    Console.WriteLine("Какое действие вы хотите выполнить:\n" +
    "пополнить/снять/проверить баланс/выйти?");
    string str = Console.ReadLine()!;
    switch (str)
    {
        case "пополнить":
            {
                decimal addSum;
                Console.Write("Введите сумму, которую хотите внести: ");
                if (decimal.TryParse(Console.ReadLine(), out addSum) && addSum > 0)
                    curBalance = bankAccount.AddMoney(curBalance, addSum);
                else Console.WriteLine("Неверная сумма");
            }
            break;
        case "снять":
            {
                decimal subSum;
                Console.Write("Введите сумму, которую хотите снять: ");
                if (decimal.TryParse(Console.ReadLine(), out subSum) && subSum > 0)
                    curBalance = bankAccount.WithdrawMoney(curBalance, subSum);
                else Console.WriteLine("Неверная сумма");

            }
            break;
        case "проверить баланс": bankAccount.PrintBalance(curBalance); break;
        case "выйти": program = false; break;
        default: Console.WriteLine("Неверная команда"); break;
    }
    Console.ReadKey();
}
while (program == true);
