namespace BankApp.Models;

public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string mail { get; set; }
    public string phoneNumber { get; set; }
    public Adress adress { get; set; }
    
    public Person(string firstName,string lastName,string mail,string phoneNumber)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.mail = mail;
        this.mail = phoneNumber;
    }
    public override string ToString()
    {
        return $"{firstName} {lastName}";
    }
}