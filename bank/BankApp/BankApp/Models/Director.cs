namespace BankApp.Models;

public class Director:Person
{
    public Director(string firstName,string lastName,string mail,string phoneNumber) :
        base( firstName, lastName, mail, phoneNumber)
    {
        
    }
    
}