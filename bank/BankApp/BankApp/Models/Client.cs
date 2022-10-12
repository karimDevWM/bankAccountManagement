namespace BankApp.Models;

public class Client:Person
{
    public BankAccount bankAccounts { get; set; }
    public Loan loans  { get; set; }
    public Advisor advisor { get; set; }
    public string password { get; set; }

    public Client(string firstName,string lastName,string mail,string phoneNumber,string password,Advisor advisor):
        base( firstName, lastName, mail, phoneNumber)
    {
        this.password = password;
        this.advisor = advisor;
    }
}

