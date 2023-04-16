using LiskovSubstitution.Interfaces;
using LiskovSubstitution.Vehicles;

namespace LiskovSubstitution.Classes
{
    public class Car : Vehicle, IDriveble
    {
        public override void StartEngine()
        {
            Console.WriteLine("Wrum wrum");
        }

        public void Driveable()
        {
            Console.WriteLine("It's driving?");
        }
    }
}

