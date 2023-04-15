using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Classes;

public class Owner : Administrator, IOwner 
{
    public void SaveToFile(string filename)
    {
        
    }
}