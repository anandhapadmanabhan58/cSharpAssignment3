//AnandhaPadmanabhan c0894441
using System;
public class BankAccount
{
    // Properties
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }
    public string Type { get; }

    // Constructors
    public BankAccount(string accountNumber, decimal initialBalance, string type = "Checking")
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
    }

    // Methods
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount:C} deposited into account {AccountNumber}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn from account {AccountNumber}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating different types of accounts using constructors
        BankAccount checkingAccount = new BankAccount("123456789", 1000);
        BankAccount savingAccount = new BankAccount("987654321", 5000, "Savings");

        // Depositing and withdrawing from accounts
        checkingAccount.Deposit(500);
        checkingAccount.Withdraw(200);

        savingAccount.Deposit(1000);
        savingAccount.Withdraw(600);
    }
}