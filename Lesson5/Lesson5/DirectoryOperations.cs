using System;
using System.IO;

namespace Lesson5
{
    public static class DirectoryOperations
    {
        public static void RemoveDir(string path)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), path.TrimEnd('/'));
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }

        public static void MoveDirPrompt(string sourcePath)
        {
            Console.Write("Destination directory: ");
            string destinationPath = Console.ReadLine();
            MoveDirAsync(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath.TrimEnd('/'))));
        }

        public static async Task MoveDirAsync(string sourcePath, string destinationPath)
        {
            sourcePath = Path.Combine(Directory.GetCurrentDirectory(), sourcePath.TrimEnd('/'));
            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destinationPath))
                {
                    await Task.Run(() => Directory.Move(sourcePath, destinationPath));
                    Console.WriteLine("Moved");
                }
                else
                {
                    Console.WriteLine("Destination directory already exists!");
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }

        public static void CopyDirPrompt(string sourcePath)
        {
            Console.Write("Destination directory: ");
            string destinationPath = Console.ReadLine();
            CopyDirAsync(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath.TrimEnd('/'))));
        }

        public static async Task CopyDirAsync(string sourcePath, string destinationPath)
        {
            sourcePath = Path.Combine(Directory.GetCurrentDirectory(), sourcePath.TrimEnd('/'));
            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destinationPath))
                {
                    await Task.Run(() => CopyDirectoryAsync(new DirectoryInfo(sourcePath), new DirectoryInfo(destinationPath)));
                    Console.WriteLine("Copied");
                }
                else
                {
                    Console.WriteLine("Destination directory already exists!");
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }

        private static async Task CopyDirectoryAsync(DirectoryInfo source, DirectoryInfo destination)
        {
            Directory.CreateDirectory(destination.FullName);
            foreach (FileInfo file in source.GetFiles())
            {
                await Task.Run(() =>file.CopyTo(Path.Combine(destination.FullName, file.Name), false));
            }

            foreach (DirectoryInfo subDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = destination.CreateSubdirectory(subDir.Name);
                await Task.Run(() => CopyDirectoryAsync(subDir, nextTargetSubDir));
            }
        }

        public static void GetDirInfoPrompt(string path)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), path.TrimEnd('/'));
            if (Directory.Exists(path))
            {
                GetDirInfo(path);
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }

        public static void GetDirInfo(string path)
        {
            var info = new DirectoryInfo(path);
            Console.WriteLine($"-----Directory Info-----\n" +
                              $"Name: {info.Name}\n" +
                              $"Parent: {info.Parent}\n" +
                              $"Creation time: {info.CreationTime}\n" +
                              $"Last write time: {info.LastWriteTime}\n" +
                              $"Root: {info.Root}\n");

            Console.WriteLine("Subdirectories:");
            foreach (var dir in info.GetDirectories())
            {
                Console.WriteLine($"- {dir.Name}");
            }

            Console.WriteLine("Files:");
            foreach (var file in info.GetFiles())
            {
                Console.WriteLine($"- {file.Name}");
            }
        }
    }
}
