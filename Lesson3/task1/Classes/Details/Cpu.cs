namespace task1.Classes.Details;

public class Cpu : Detail
{
    public string Socket { get;}
    public string Cores { get;}
    public string Frequency { get;}
    public Cpu(decimal price, string supplier, string country,
        string name, string socket, string cores, string frequency)
        : base(price, supplier, country, name)
    {
        Socket = socket;
        Cores = cores;
        Frequency = frequency;
    }

    public override string GetInfo()
    {
        return $"{Name}  {Socket}  {Cores}  {Frequency}  Price: {Price}";
    }
}