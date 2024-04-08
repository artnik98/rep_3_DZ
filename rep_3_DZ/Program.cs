

//Работа 1
using System;

class Phone
{
    private string number;
    private string model;
    private double weight;

    public Phone(string number, string model, double weight)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }

    public Phone(string number, string model) : this(number, model, 0) { }

    public Phone() : this("undefined", "undefined", 0) { }

    public void receiveCall(string callerName)
    {
        Console.WriteLine($"Звонит {callerName}");
    }

    public void receiveCall(string callerName, string callerNumber)
    {
        Console.WriteLine($"Звонит {callerName}, номер телефона: {callerNumber}");
    }

    public string getNumber()
    {
        return number;
    }

    public void sendMessage(params string[] phoneNumbers)
    {
        Console.WriteLine("Отправляются сообщения на следующие номера:");
        foreach (var number in phoneNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Phone phone1 = new Phone("123456789", "iPhone 12", 0.2);
        Phone phone2 = new Phone("987654321", "Samsung Galaxy S20");
        Phone phone3 = new Phone();

        Console.WriteLine("Информация о телефонах:");
        Console.WriteLine($"Телефон 1: Номер - {phone1.getNumber()}, Модель - {phone1.model}, Вес - {phone1.weight}");
        Console.WriteLine($"Телефон 2: Номер - {phone2.getNumber()}, Модель - {phone2.model}, Вес - {phone2.weight}");
        Console.WriteLine($"Телефон 3: Номер - {phone3.getNumber()}, Модель - {phone3.model}, Вес - {phone3.weight}");

        phone1.receiveCall("Анна");
        phone2.receiveCall("Петр", "987654321");

        phone3.sendMessage("111111111", "222222222", "333333333");
    }
}

//Работа 2


class CreditCard
{
    private string accountNumber;
    private double currentBalance;

    public CreditCard(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.currentBalance = initialBalance;
    }

    public void Deposit(double amount)
    {
        currentBalance += amount;
        Console.WriteLine($"На счет {accountNumber} зачислено {amount} рублей.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= currentBalance)
        {
            currentBalance -= amount;
            Console.WriteLine($"Со счета {accountNumber} снято {amount} рублей.");
        }
        else
        {
            Console.WriteLine($"Недостаточно средств на счете {accountNumber} для снятия {amount} рублей.");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Номер счета: {accountNumber}");
        Console.WriteLine($"Текущий баланс: {currentBalance} рублей");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CreditCard card1 = new CreditCard("1234 5678 9012 3456", 1000);
        CreditCard card2 = new CreditCard("9876 5432 1098 7654", 2000);
        CreditCard card3 = new CreditCard("2468 1357 8024 6813", 500);

        card1.Deposit(500);
        card2.Deposit(1000);
        card3.Withdraw(300);

        Console.WriteLine("Текущая информация о карточках:");
        card1.ShowInfo();
        Console.WriteLine();
        card2.ShowInfo();
        Console.WriteLine();
        card3.ShowInfo();
    }
}
