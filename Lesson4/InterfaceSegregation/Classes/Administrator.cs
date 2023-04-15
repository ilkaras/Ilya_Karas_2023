using InterfaceSegregation.Classes;
using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Classes;

public class Administrator : User, IAdministrator
{
    public void GetDataFromFile(string filename)
    {
        
    }

    public void CheckFile(string filename)
    {
        
    }
}