using Lesson3Task2.Classes;

namespace Lesson3Task2;

public class Employee : Person
{

    public Work work { get; }

    public Employee(string name, string surname, decimal age,Work work) : base(name, surname, age)
    {
        this.work = work;
    }
}