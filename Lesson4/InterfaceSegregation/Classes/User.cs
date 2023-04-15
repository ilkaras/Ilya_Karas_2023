using InterfaceSegregation.Interfaces;
namespace InterfaceSegregation.Classes
{
    public class User : IUser
    {
        public string ReadFromFile(string filename)
        {
            return "";
        }

        public void WriteToFile(string filename)
        {
            
        }

        public void DeleteFile(string filename)
        {
            
        }

        public void DownloadFile(string filename)
        {
            
        }

        public void CopyFile(string filename)
        {
            
        }
    }
}