class BankAccount
{
private int balance;
public int Balance
{
    get => balance;
    set => balance = value;
}


public int Deposit(int amount)
    {
    return balance += amount;
    }
public int Withdraw(int amount)
    {
    return balance -= amount;
    }
public int ShowSaldo()
    {
    return balance;
    }
}
