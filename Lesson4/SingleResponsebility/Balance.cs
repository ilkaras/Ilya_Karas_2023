namespace SingleResponsibility;

public class Balance
{
    AddPeople addPeople = new AddPeople();
    Database database = new Database();

    public void GetBalance(int id)
    {
        Console.WriteLine($"Your balance is: {GetBalanceById(id)}");
    }

    public decimal GetBalanceById(int id)
    {
        var customer = addPeople.CustomersList.FirstOrDefault(x => x.Id == id);
        return customer.Balance;
    }

    public Customer GetById(int id)
    {
        return addPeople.CustomersList.FirstOrDefault(x => x.Id == id);
    }

    public void UpdateBalance(int id, decimal newBalance)
    {
        var customer = GetById(id);
        customer.Balance = newBalance;
        database.SaveToDatabase();
    }
}
    