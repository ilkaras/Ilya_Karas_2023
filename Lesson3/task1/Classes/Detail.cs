namespace task1.Classes;

public class Detail
{
    public decimal Price { get; }
    public string Supplier { get; }
    public string Country { get; }
    public string Name { get; }

    public Detail(decimal price, string supplier, string country, string name)
    {
        Price = price;
        Supplier = supplier;
        Country = country;
        Name = name;
    }
    public virtual string GetInfo()
    {
        return $"{Name}  {Supplier} {Country}  Price: {Price}";
    }
}
