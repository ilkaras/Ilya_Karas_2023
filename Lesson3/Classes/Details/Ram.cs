using System.Net.Sockets;

namespace Les3pr1.Classes.Details;
public class Ram : Detail
{
    public string Type { get;}
    public string Size { get;}
    public Ram(decimal price, string supplier, string country,
        string name, string type, string size)
        : base(price, supplier, country, name)
    {
        Type = type;
        Size = size;
    }

    public string GetInfo()
    {
        return $"{Name}  {Size}  {Type}  Price: {Price}";
    }
}