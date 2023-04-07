using System.Net.Sockets;

namespace Les3pr1.Classes.Details;

public class Gpu : Detail
{
    public string Memory { get; set; }
    public string Speed { get; set; }
    public Gpu(decimal price, string supplier, string country,
        string name, string memory, string speed)
        : base(price, supplier, country, name)
    {
        Memory = memory;
        Speed = speed;
    }

    public string GetInfo()
    {
        return $"{Name}  {Memory}  {Speed}  Price: {Price}";
    }
}