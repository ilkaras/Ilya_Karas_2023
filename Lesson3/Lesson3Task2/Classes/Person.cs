namespace Lesson3Task2.Classes;

public class Person
{
    public string Name { get;}
    public string Surname { get;}
    public decimal Age { get;}
    public Person(string name, string surname, decimal age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
}
