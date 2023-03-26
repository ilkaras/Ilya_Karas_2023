// class Person
// {
//     public string FirstName { get; }
//     public int Age { get; }
//     public string Adress { get; }
//     public Person(string firstName, int age, string street)
//     {
//         FirstName = firstName;
//         Age = age;
//         Adress = street;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         List<Person> people = new List<Person>()
//         {
//             new Person("Tom", 18, "Hmelnitskogo"),
//             new Person("Bob", 50, "Kropyvnytskogo"),
//             new Person("Sam", 8, "Yarmaka"),
//             new Person("Tom", 10, "Chototo"),
//             new Person("Bob", 30, "Popova"),
//             new Person("Sam", 19, "Pazaeva"),
//             new Person("Tom", 23, "Krimskaya"),
//             new Person("Bob", 17, "Kropyvnytskogo"),
//             new Person("Sam", 42, "Hmelnitskogo"),
//             new Person("Tom", 6, "Zelenskogo")
//         };
//
//         Console.WriteLine("Enter the name of Person");
//         string name = Console.ReadLine();
//
//         List<Person> founded = people.FindAll(p => p.FirstName == name && p.Age >= 18);
//         Console.WriteLine($"People who has name {name} and older than 17: ");
//         foreach (Person p in founded)
//         {
//             Console.WriteLine($"{p.FirstName} - {p.Age} - {p.Adress}");
//         }
//     }
// }