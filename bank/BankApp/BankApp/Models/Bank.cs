namespace BankApp.Models;

public class Bank
{
    public string name { get; set; }
    public Adress adress { get; set; }
    public Director director { get; set; }
    public List<Client> clients { get; set; } = new List<Client>();

    public Bank(string name,Adress adress,Director director)
    {
        this.name = name;
        this.adress = adress;
        this.director = director;
    }

    public Client? SearchClientForLogin(string mail, string password)
    {
        if (clients.Count == 0)
        {
            return null;
        }

        foreach (var client in clients)
        {
            if (client.mail == mail && client.password == password)
            {
                return client;
            }
        }

        return null;

    }
}