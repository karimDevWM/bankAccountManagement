namespace BankApp.Models;

public class Loan
{
    public DateTime dateOfSubscription { get; set; }
    public Client clients { get; set; }
    public double balance { get; set; }
    public int draft { get; set; }
}