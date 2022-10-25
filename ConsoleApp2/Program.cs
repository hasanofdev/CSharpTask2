using static System.Console;
namespace CSharpTask2;

class Program
{
    static void Main()
    {

        Client client1 = new(Guid.NewGuid(), "Polad", "Hesenov", new DateOnly(2000, 01, 01), 1500, "Baku", "Nizami");
        Client client2 = new(Guid.NewGuid(), "Elsad", "Hesenov", new DateOnly(2001, 01, 01), 2000, "Baku", "Azadliq");

        Ceo ceo = new(Guid.NewGuid(), "Rauf", "Farhadov", new DateOnly(1999, 03, 27), 4500, ".Net Developer");
       
        Manage manage = new(Guid.NewGuid(), "Michel", "Abdullayev", new DateOnly(2005, 01, 01), 3500, "HR Department");

        Credit credit1 = new(Guid.NewGuid(), client1, 15000, 20, 18);
        Credit credit2 = new(Guid.NewGuid(), client2, 20000, 20, 18);

        Operation operation = new(Guid.NewGuid(), "Credit", new DateTime(2022, 9, 5));

        List<Operation> operations = new();
        operations.Add(operation);

        Worker worker1 = new(Guid.NewGuid(), "Worker1", "Worker1Surname", new DateOnly(2005, 01, 01), 3500, "HR Department", new DateOnly(2022, 01, 01), new DateOnly(2022, 10, 01), operations);
        Worker worker2 = new(Guid.NewGuid(), "Worker2", "Worker2Surname", new DateOnly(2002, 01, 01), 2500, "Credit Ads", new DateOnly(2019, 03, 10), new DateOnly(2022, 10, 01), operations);
        Worker worker3 = new(Guid.NewGuid(), "Worker3", "Worker3Surname", new DateOnly(2001, 01, 01), 1500, "Enginering Department", new DateOnly(2018, 05, 25), new DateOnly(2022, 10, 01), operations);

        Bank bank = new("Azer Turk Bank", 25000000, 1000000, ceo);

        bank.AddManage(manage);

        bank.AddWorker(worker1);
        bank.AddWorker(worker2);
        bank.AddWorker(worker3);

        bank.AddClient(client1);
        bank.AddClient(client2);

        WriteLine("Client Credits: ");
        bank.ShowClientCredit(client1?.Name);

        bank.AddCredit(credit1);
        bank.AddCredit(credit2);

        WriteLine();
        WriteLine("Show All Kredits: ");
        
        bank.ShowAllCredit();

        WriteLine();
        bank.PayCredit(client1, 3000);
        WriteLine($"Credit Debt: {credit1.Amount}");

    }
}