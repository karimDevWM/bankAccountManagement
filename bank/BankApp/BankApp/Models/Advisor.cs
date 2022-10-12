namespace BankApp.Models;

public class Advisor:Person
{
    public Advisor(string firstName,string lastName,string mail,string phoneNumber) :
        base( firstName, lastName, mail, phoneNumber)
    {
        
    }
}