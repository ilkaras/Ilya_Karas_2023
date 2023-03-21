class Person
{
    public string FirstName { get; }
    public int Age { get; }
    public Person(string firstName, int age)
    {
        FirstName = firstName;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>()
        {
            new Person("Tom", 10),
            new Person("Bob", 50),
            new Person("Sam", 20)
        };

        Console.WriteLine("Enter the first number");
        int firstnum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int secondnum = int.Parse(Console.ReadLine());

        List<Person> founded = people.FindAll(p => p.Age >= firstnum && p.Age <= secondnum);
        Console.WriteLine($"People between {firstnum} and {secondnum}: ");
        foreach (Person p in founded)
        {
            Console.WriteLine($"{p.FirstName} - {p.Age}");
        }
    }
}    
   