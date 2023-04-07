namespace Lesson3Task2.Classes;

public class Search
{
    private PeopleList peoples = new PeopleList();

    public List<Employee> FindAllPeople(string profession, decimal salary)
    {
        List<Employee> founded = peoples.empolyees.FindAll(p => p.work.Profession == profession && p.work.Salary <= salary);
        return founded;
    }

    public Employee FindPerson(List<Employee> founded)
    {
        var result = founded.OrderBy(p => p.work.Salary).ToList();
        result.Reverse();
        return result[0];
    }
}