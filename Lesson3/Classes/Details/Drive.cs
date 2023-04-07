namespace Les3pr1.Classes.Details;

public class Drive : Detail
{
    public string Size { get;}
    public string Speed { get;}
    public string Type { get;}
    public string Interface { get;}
    public string? Lifetime { get;}
    public Drive(decimal price, string supplier, string country, string name, string type,
        string size, string speed, string _interface, string? lifetime)
        : base(price, supplier, country, name)
    {
        Size = size;
        Speed = speed;
        Interface = _interface;
        Lifetime = lifetime;
        Type = type;
    }
    public string GetInfo()
    {
        return $"{Name}  {Type} {Interface}  {Speed}  Price: {Price}";
    }
}