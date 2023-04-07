namespace Lesson3Task2.Classes;

public class PeopleList
{
    public List<Employee> empolyees { get; } = new List<Employee>
    {  
            new Employee("Ethan", "Smith", 28,new Lawyer("lawyer",1242)),
            new Employee("Emily", "White", 28,new Lawyer("engineer",5000)),
            new Employee("Liam", "Williams", 28,new Lawyer("psychologist",3123)),
            new Employee("Chloe", "White", 28,new Lawyer("teacher",3242)),
            new Employee("Noah", "Jones", 28,new Lawyer("lawyer",2212)),
            new Employee("Olivia", "Clark", 28,new Lawyer("surgeon",4313)),
            new Employee("William", "Davis", 28,new Lawyer("teacher",6012)),
            new Employee("Mia", "Parker", 28,new Lawyer("surgeon",7042)),
            new Employee("James", "Rodriguez", 28,new Lawyer("psychologist",2133)),
            new Employee("Charlotte", "Wilson", 28,new Lawyer("engineer",7452)),
            new Employee("Lucas", "Thompson", 28,new Lawyer("lawyer",1234)),
            new Employee("Amelia", "Robinson", 28,new Lawyer("surgeon",2341)),
            new Employee("Alexander", "Johnson", 28,new Lawyer("teacher",7523)),
            new Employee("Harper", "Miller", 28,new Lawyer("engineer",4325)),
    };
}