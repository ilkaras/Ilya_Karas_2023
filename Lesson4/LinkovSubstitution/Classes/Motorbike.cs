using LiskovSubstitution.Vehicles;
using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Classes
{
    public class Motorbike : Vehicle, IRideble
    {
        public override void StartEngine()
        {
            Console.WriteLine("GRRRR rrrrrrr");
        }

        public void Rideble()
        {
            Console.WriteLine("It's riding?");
        }
    }
}
