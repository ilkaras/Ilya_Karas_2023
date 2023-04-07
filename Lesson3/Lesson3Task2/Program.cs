using Lesson3Task2;
using Lesson3Task2.Classes;

namespace Les3pr1.Classes;

class Program
{
    public static void Main()
    {
        Search search = new Search();
        string profession;
        decimal salary;
        Console.WriteLine("Write the name of the profession");
        profession = Console.ReadLine().ToLower();
        Console.WriteLine("Write max amount of Salary for Employee");
        salary = Convert.ToDecimal(Console.ReadLine());

        var founded = search.FindAllPeople(profession, salary);
        var result = search.FindPerson(founded);
        Console.WriteLine($"Person you need is {result.Name}");
    }
}