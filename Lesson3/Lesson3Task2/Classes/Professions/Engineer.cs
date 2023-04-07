using Lesson3Task2.Classes;

namespace Lesson3Task2;

public class Engineer : Work
{
    public string Features { get; }

    public Engineer(string profession, decimal salary,string features) : base(profession,salary)
    {
    }

    public override string Resume()
    {
        return $"{Profession}  {Salary}  ''";
    }
}