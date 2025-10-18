public class BankAccount
{

    // public decimal balance;
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        Deposit(initialBalance);
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }

        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive");
        }

        if (amount > balance)
        {
            throw new ArgumentException("Insufficient funds");
        }

        balance -= amount;
    }
}