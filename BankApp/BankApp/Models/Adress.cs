namespace BankApp.Models;

public class Adress
{
    public  string country { get; set; }
    public  string city { get; set; }
    public string street { get; set; }
    public int number { get; set; }
    public int postalCode { get; set; }
    
    public Adress(string country,string city,string street,int number,int postalCode)
    {
        this.country = country;
        this.city = city;
        this.street = street;
        this.number = number;
        this.postalCode = postalCode;
    }
}