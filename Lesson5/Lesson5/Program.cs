using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose operation:\n" +
                                  "1. Read file\n" +
                                  "2. Remove file or directory\n" +
                                  "3. Move file or directory\n" +
                                  "4. Copy file or directory\n" +
                                  "5. Get file or directory info\n" +
                                  "6. Show current directory content\n" +
                                  "7. Change directory\n" +
                                  "8. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        FileOperations.ReadFilePrompt();
                        break;
                    case "2":
                        FileOperations.RemoveFileOrDirPrompt();
                        break;
                    case "3":
                        FileOperations.MoveFileOrDirPrompt();
                        break;
                    case "4":
                        FileOperations.CopyFileOrDirPrompt();
                        break;
                    case "5":
                        FileOperations.GetFileInfoOrDirInfoPrompt();
                        break;
                    case "6":
                        FileSystemOperations.ShowCurrentDirectoryContent();
                        break;
                    case "7":
                        Console.Write("Enter directory name or 'up' to go up: ");
                        string newDir = Console.ReadLine();
                        FileSystemOperations.ChangeDirectory(newDir);
                        break;
                    case "8":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            }
        }
    }
}
