class BankAccount
{
    private int _balance;
    public int Balance
    {
        get => _balance;
        set => _balance = value;
    }


    public int Deposit(int amount)
        {
        return Balance += amount;
        }
    public int Withdraw(int amount)
        {
        return Balance -= amount;
        }
    public int ShowSaldo()
    {
        return Balance;
    }
}
