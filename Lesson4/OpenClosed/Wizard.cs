namespace Open_Closed;

public class Wizard

{
    public class Magic
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Your name is: {Name}");
        }
    }
}