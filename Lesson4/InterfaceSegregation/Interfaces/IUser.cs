namespace InterfaceSegregation.Interfaces;

public interface IUser
{
    public string ReadFromFile(string filename);
    public void WriteToFile(string filename);
    public void DeleteFile(string filename);
    public void DownloadFile(string filename);
    public void CopyFile(string filename);
}