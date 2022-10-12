namespace BankApp.Models;

public class BankAccount
{
    public double balance { get; set; }
    public Client clients { get; set; }
    public int accountNumber { get; set; }
}