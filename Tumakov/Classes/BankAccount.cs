using System;

namespace Tumakov.Classes
{
    public enum TypeAccount
    {
        Save,
        Check,
        Credit
    }
    public class BankAccount
    {
        private static int NumberCounter = 0;
        private string Number;
        private decimal balance;
        private TypeAccount typeAccount;

        public BankAccount(/*string number, */decimal beginningBalance, TypeAccount typeAccount)
        {
            //this.Number = number;
            this.Number = GenerateNumber();
            this.balance = beginningBalance;
            this.typeAccount = typeAccount;
        }

        public void Transfer(BankAccount destinationAccount, decimal sum)
        {
            if (destinationAccount == this)
            {
                Console.WriteLine("Нельзя переводить деньги на тот же счет\n");
                return;
            }

            if (sum > 0 && sum <= balance)
            {
                balance -= sum;
                destinationAccount.balance += sum;
                Console.WriteLine($"Вы перевели со счета {Number} на счет {destinationAccount.Number} сумму {sum}. Текущий баланс: {balance}\n");
            }
            else
            {
                Console.WriteLine($"Недостаточно средств или неккоректная сумма перевода\n");
            }
        }

        public void Refill(decimal sum)
        {
            if (sum > 0)
            {
                balance += sum;
                Console.WriteLine($"Ваш счет пополнен на сумму {sum} Текущий баланс: {balance}\n");
            }
            else
            {
                Console.WriteLine("Сумма пополнения должна быть положительной\n");
            }
        }

        private string GenerateNumber()
        {
            NumberCounter++;
            return $"{NumberCounter:0000}";
        }

        public void Withdraw(decimal sum)
        {
            if (sum > 0 && sum <= balance)
            {
                balance -= sum;
                Console.WriteLine($"Вы сняли со счета {sum} Текущий баланс: {balance}\n");
            }
            else
            {
                Console.WriteLine($"Недостаточно средств или неккоректная сумма снятия\n");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Номер счета: {Number}");
            Console.WriteLine($"Текущий баланс: {balance}");
            Console.WriteLine($"Тип счета: {typeAccount}\n");
        }


    }
}
