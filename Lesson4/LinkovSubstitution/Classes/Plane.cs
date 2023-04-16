using LiskovSubstitution.Interfaces;
using LiskovSubstitution.Vehicles;

namespace LiskovSubstitution.Classes
{
    public class Plane : Vehicle, IFlyable
    {
        public override void StartEngine()
        {
            Console.WriteLine("Wzzzzzzzz");
        }

        public void Flyable()
        {
            Console.WriteLine("It's flying?");
        }
    }
}

