namespace InterfaceSegregation.Interfaces;

public interface IOwner : IAdministrator
{
    public void SaveToFile(string filename);
}