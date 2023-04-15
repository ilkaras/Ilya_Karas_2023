using LiskovSubstitution.Vehicles;

namespace LiskovSubstitution.Interfaces
{
    public class Flyable : Vehicle
    {
        public string WowEffect { get; }
        public override void StartEngine()
        {
            Console.WriteLine("It's flying?");
        }
    }
}

