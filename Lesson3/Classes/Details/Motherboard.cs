namespace Les3pr1.Classes.Details;
public class Motherboard : Detail
{
    public string Socket { get;}
    public decimal RamSlotsCount { get;}
    public string RamSlotType { get;}

    public Dictionary<string, int> Interfaces = new Dictionary<string, int>();

    public Motherboard(decimal price, string supplier, string country, string name,
        string socket, decimal ramSlotsCount, string ramSlotType, Dictionary<string, int> interfaces)
        : base(price, supplier, country, name)
    {
        Socket = socket;
        RamSlotsCount = ramSlotsCount;
        RamSlotType = ramSlotType;
        Interfaces = interfaces;
    }

    public string GetInfo()
    {
        return $"{Name}  {Socket}  {RamSlotsCount}-{RamSlotType}  Price: {Price}";
    }
}