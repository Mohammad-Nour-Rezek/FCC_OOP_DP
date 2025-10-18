
// BankAccount account1 = new BankAccount();

// account1.balance = 100m;

// Console.WriteLine($"The Balance is: {account1.balance}");

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(80);

System.Console.WriteLine(bankAccount.GetBalance());
