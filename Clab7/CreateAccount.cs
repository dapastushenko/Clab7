using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clab7
{
    class CreateAccount
    {
        static void Main(string[] args)
        {
            BankAccount berts = NewBankAccount();
            TestDeposit(berts);
            TestWithdraw(berts);
            Write(berts);

            BankAccount freds = NewBankAccount();
            TestDeposit(freds);
            TestWithdraw(freds);
            Write(freds);

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            //Console.Write("Enter the account number   : ");
            //long number = long.Parse(Console.ReadLine());
            //long number = BankAccount.NextNumber();

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //created.accNo = number;
            //created.accBal = balance;
            //created.accType = AccountType.Checking;

            created.Populate(balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());

        }

        public static void TestDeposit(BankAccount bankAccount)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            bankAccount.Deposit(amount);
        }

        public static void TestWithdraw(BankAccount bankAccount)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!(bankAccount.Withdraw(amount))) { Console.WriteLine("Insufficient funds."); }
        }
    }
}
