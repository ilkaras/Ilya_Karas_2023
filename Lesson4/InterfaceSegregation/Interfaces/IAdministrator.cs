namespace InterfaceSegregation.Interfaces;

public interface IAdministrator : IUser
{
    public void GetDataFromFile(string filename);
    public void CheckFile(string filename);
}