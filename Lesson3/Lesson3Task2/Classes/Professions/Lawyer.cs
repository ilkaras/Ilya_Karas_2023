using Lesson3Task2.Classes;

namespace Lesson3Task2;

public class Lawyer : Work
{
    public Lawyer(string profession, decimal salary) : base(profession,salary)
    {
    }

    public override string Resume()
    {
        return $"{Profession}  {Salary}  ''";
    }
}
