namespace BankApp.Models;

public class BankAccount
{
    public double balance { get; set; }
    public Client clients { get; set; }
    public int accountNumber { get; set; }

    public BankAccount Withdraw(BankAccount account)
    {
        Console.WriteLine("ToDo");
        return account;
    }
    public BankAccount Deposit(BankAccount account)
    {
        Console.WriteLine("ToDo");
        return account;
    }
    public BankAccount Transfer(BankAccount account)
    {
        Console.WriteLine("ToDo");
        return account;
    }
}