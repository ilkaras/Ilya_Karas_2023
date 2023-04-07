using Lesson3Task2.Classes;

namespace Lesson3Task2;

public class Surgeon : Work
{
    public string Features { get; }

    public Surgeon(string profession, decimal salary,string features) : base(profession,salary)
    {
    }

    public override string Resume()
    {
        return $"{Profession}  {Salary}  ''";
    }
}