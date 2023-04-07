namespace Lesson3Task2.Classes;

public class Work
{
    public string Profession { get;}
    public decimal Salary { get;}

    public Work( string profession, decimal salary)
    {
        Profession = profession;
        Salary = salary;
    }

    public virtual string Resume()
    {
        return $"{Profession}  {Salary}";
    }
}