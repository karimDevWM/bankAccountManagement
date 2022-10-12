using BankApp.Models;

Adress bankAdress = new Adress(
    country: "country",
    city: "city",
    street: "street",
    number: 2,
    postalCode: 38000
);
Director director = new Director(
    firstName:"John",
    lastName:"Doe",
    mail:"rrr@ttt.com",
    phoneNumber:"09-00-00-00-00"
    );

Bank bank = new Bank(
    name:"SuperBank",
    adress:bankAdress,
    director: director
);

public class Terminal{
    public Bank bank { get; set; }
    public Client? client { get; set; }
    public Terminal(Bank bank)
    {
        this.bank = bank;
    }
    public void ClientMenu()
    {
        Console.WriteLine($"Welcome to the bank {bank.name}");
        Console.WriteLine("Menu :");
        if (client != null) 
        {
            Console.WriteLine("1: Select bank account");
            Console.WriteLine("2: Select loan");
            Console.WriteLine($"3: Request an appointment with {client.advisor}");
            Console.WriteLine("4: Logout");
            string number = "0";
            while (number != "1" && number != "2" && number != "3" && number != "4")
            {
                number = Console.ReadLine();
            }
            switch (number)
            {
                case "1":
                {
                    BankAccountMenu();
                    break;
                }
                case "2":
                {
                    LoanMenu();
                    break;
                }
                case "3":
                {
                    AppointementMenu();
                    break;
                }
                case "4":
                {
                    LogoutMenu();
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("1: Login");
            Console.WriteLine("1: Create account");
        }
        
    }

    public void BankAccountMenu()
    {
        Console.WriteLine("Select a account:");
        foreach (var account in client.bankAccounts)
        {
            
        }
    }
    public void LoanMenu()
    {
        
    }
    public void AppointementMenu()
    {
        
    }
    public void LoginMenu()
    {
        Console.WriteLine("Mail:");
        var mail = Console.ReadLine();
        Console.WriteLine("Password:");
        var password = Console.ReadLine();
        client = bank.SearchClientForLogin(mail, password);
        if (client == null)
        {
            Console.WriteLine("Mail or password incorect");
        }
        else
        {
            Console.WriteLine("Login success");
        }

        ClientMenu();
    }
    public void LogoutMenu()
    {
        client = null;
        ClientMenu();
    }
}