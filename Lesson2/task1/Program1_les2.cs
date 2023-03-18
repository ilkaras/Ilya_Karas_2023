List<Products> things = new List<Products>()
{
    new Products("a", 1),
    new Products("b", 2),
    new Products("c", 3),
    new Products("d", 4),
    new Products("e", 5),
    new Products("f", 6),
    new Products("g", 7),
    new Products("j", 8),
    new Products("k", 9),
    new Products("l", 10),
};

Console.WriteLine("> or <");
var variant = Console.ReadLine();

if (variant == "<")
{
    var sortedproducts = things.OrderBy(p => p.price);
    foreach (var p in sortedproducts)
    {
        Console.WriteLine($" Label ={p.label} price ={p.price}");
    }
}
else if (variant == ">") 
{
    var sortedproducts = things.OrderBy(p => p.price).Reverse();
    foreach (var p in sortedproducts)
    {
        Console.WriteLine($" Label ={p.label} price ={p.price}");
    }
}
else {
Console.WriteLine("Error! Pleas reload the application");
}

class Products
{
    public string label { get; }
    public int price { get; }
    public Products(string firstName, int salary)
    {
        label = firstName;
        price = salary;
    }
}