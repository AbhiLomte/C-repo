using System;
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException() : base("Insufficient balance in the account.")
    {
    }

    public InsufficientBalanceException(string message) : base(message)
    {
    }

    public InsufficientBalanceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}


public class BankAccount
{
    private string accountNumber;
    private string accountHolderName;
    private decimal balance;

    // Constructor
    public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = initialBalance;
    }

   
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
        }

        balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance is {balance:C}.");
    }

    
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
        }

        if (amount > balance)
        {
            throw new InsufficientBalanceException();
        }

        balance -= amount;
        Console.WriteLine($"Withdrawn {amount:C}. New balance is {balance:C}.");
    }

    
    public void CheckBalance()
    {
        Console.WriteLine($"Account balance for {accountHolderName} ({accountNumber}): {balance:C}");
    }
}


class que3
{
    static void Main()
    {
        try
        {
            // Creating a bank account
            BankAccount account = new BankAccount("12341234", "Abhishek", 1000.00m);

            // Testing deposit
            account.Deposit(500.00m);

            // Testing withdrawal (normal case)
            account.Withdraw(200.00m);

            // Testing withdrawal (insufficient balance)
            account.Withdraw(2000.00m); // This should throw InsufficientBalanceException

            // Checking balance
            account.CheckBalance();
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Additional handling specific to InsufficientBalanceException
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Additional handling for argument-related exceptions (like negative amount)
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            // Generic exception handling
        }
        Console.Read();
    }
}