
class BankAccount
{
    private static long nextAccNo = 123;
    private long accNo;
    private decimal accBal;
    private AccountType accType;

    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    //public AccountType Type()
    //{
    //    return accType;
    //}

    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextAccNo++;
    }

    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal;
    }

    public bool Withdraw(decimal amount)
    {
        if (accBal < amount)
        {
            return false;
        }
        else
        {
            accBal -= amount;
            return true;
        }
    }

    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
            this.Deposit(amount);
    }
}