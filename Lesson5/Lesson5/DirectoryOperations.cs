using System;
using System.IO;

namespace Lesson5
{
    public static class DirectoryOperations
    {
        public static void MoveDirPrompt(string sourcePath)
        {
            Console.Write("Destination directory: ");
            string destinationPath = Console.ReadLine();
            MoveDir(sourcePath, destinationPath);
        }

        public static void MoveDir(string sourcePath, string destinationPath)
        {
            sourcePath = Path.Combine(Directory.GetCurrentDirectory(), sourcePath.TrimEnd('/'));
            destinationPath = Path.Combine(Directory.GetCurrentDirectory(), destinationPath);

            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destinationPath))
                {
                    Directory.Move(sourcePath, destinationPath);
                    Console.WriteLine("Directory moved.");
                }
                else
                {
                    Console.WriteLine("Destination directory already exists!");
                }
            }
            else
            {
                Console.WriteLine("Source directory does not exist.");
            }
        }

        public static void CopyDirPrompt(string sourcePath)
        {
            Console.Write("Destination directory: ");
            string destinationPath = Console.ReadLine();
            CopyDir(sourcePath, destinationPath);
        }

        public static void CopyDir(string sourcePath, string destinationPath)
        {
            sourcePath = Path.Combine(Directory.GetCurrentDirectory(), sourcePath.TrimEnd('/'));
            destinationPath = Path.Combine(Directory.GetCurrentDirectory(), destinationPath);

            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);

                    foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(sourcePath, destinationPath));
                    }

                    foreach (string filePath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(filePath, filePath.Replace(sourcePath, destinationPath), true);
                    }

                    Console.WriteLine("Directory copied.");
                }
                else
                {
                    Console.WriteLine("Destination directory already exists!");
                }
            }
            else
            {
                Console.WriteLine("Source directory does not exist.");
            }
        }

        public static void GetDirInfoPrompt(string path)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), path.TrimEnd('/'));
            if (Directory.Exists(path))
            {
                var info = new DirectoryInfo(path);
                Console.WriteLine($"-----Directory Info-----\n" +
                                  $"Name: {info.Name}\n" +
                                  $"Parent: {info.Parent}\n" +
                                  $"Creation time: {info.CreationTime}\n" +
                                  $"Last write time: {info.LastWriteTime}\n" +
                                  $"Attributes: {info.Attributes}\n");
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }

        public static void RemoveDir(string path)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), path.TrimEnd('/'));
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine("Directory removed.");
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }
    }
}