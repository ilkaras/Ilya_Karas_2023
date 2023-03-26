class Owner
{
    public int Id { get; }
    public string Name { get; }
    public string Adress { get; }
    public Owner(int firstName, string age, string street)
    {
        Id = firstName;
        Name = age;
        Adress = street;
    }
}

class Car
{
    public string Number { get; }
    public int OwnerId { get; }
    public Car(string number, int owner_id)
    {
        Number = number;
        OwnerId = owner_id;
    }
}

class Program
{
    public static void Main()
    {
        List<Owner> people = new List<Owner>()
        {
            new Owner(1, "Tom", "Hmelnitskogo"),
            new Owner(2, "Bob", "Kropyvnytskogo"),
            new Owner(3, "Sam", "Yarmaka"),
            new Owner(4, "Tom", "Zelenskogo"),

        };
        List<Car> cars = new List<Car>()
        {
            new Car("1111", 1),
            new Car("2222", 2),
            new Car("3333", 3),
            new Car("666", 4),
        };

        Console.WriteLine("Enter the number of car");
        string want_to_find = Console.ReadLine();

        List<Car> founded = cars.FindAll(c => c.Number == want_to_find );

        var result = from o in people
            from c in cars
            where want_to_find == c.Number
            where o.Id == c.OwnerId
            select o;
        Console.WriteLine($"Name and Adress of owner`s car: ");
        foreach (var owner in result)
        {
            Console.WriteLine($"{owner.Name} - {owner.Adress}");
        }
    }
}
