using System;
using System.IO;

namespace Lesson5
{
    public static class FileSystemOperations
    {
        public static void ShowCurrentDirectoryContent()
        {
            string currentPath = Directory.GetCurrentDirectory();
            var currentDirectory = new DirectoryInfo(currentPath);
            var files = currentDirectory.GetFiles();
            var dirs = currentDirectory.GetDirectories();

            Console.WriteLine($"Current directory: {currentPath}\n");
            Console.WriteLine("Name - Change date - Type - Creation time");

            foreach (var dir in dirs)
            {
                Console.WriteLine($"{dir.Name} - {dir.LastWriteTime} - Folder - {dir.CreationTime}");
            }

            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} - {file.LastWriteTime} - File - {file.CreationTime}");
            }
        }

        public static void ChangeDirectory(string name)
        {
            if (name == "up")
            {
                var parent = Directory.GetParent(Directory.GetCurrentDirectory());
                if (parent != null)
                {
                    Directory.SetCurrentDirectory(parent.FullName);
                }
            }
            else
            {
                var dir = Path.Combine(Directory.GetCurrentDirectory(), name);
                if (Directory.Exists(dir))
                {
                    Directory.SetCurrentDirectory(dir);
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                }
            }
        }
    }
}