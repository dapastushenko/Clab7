using System;

public class Test
{
    public static void Main()
    {
        BankAccount bankAccount1 = new BankAccount();
        bankAccount1.Populate(100);

        BankAccount bankAccount2 = new BankAccount();
        bankAccount2.Populate(100);

        Console.WriteLine("Before transfer");
        Console.WriteLine("{0} {1} {2}", bankAccount1.Type(), bankAccount1.Number(), bankAccount1.Balance());
        Console.WriteLine("{0} {1} {2}", bankAccount2.Type(), bankAccount2.Number(), bankAccount2.Balance());

        bankAccount1.TransferFrom(bankAccount2, 10);

        Console.WriteLine("After transfer");
        Console.WriteLine("{0} {1} {2}", bankAccount1.Type(), bankAccount1.Number(), bankAccount1.Balance());
        Console.WriteLine("{0} {1} {2}", bankAccount2.Type(), bankAccount2.Number(), bankAccount2.Balance());

        Console.WriteLine("Press any key to exit!");
        Console.ReadKey();
    }
}
