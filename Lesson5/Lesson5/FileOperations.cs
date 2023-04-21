using System;
using System.IO;

namespace Lesson5
{
    public static class FileOperations
    {
        public static void ReadFilePrompt()
        {
            Console.Write("File name for read: ");
            string filePath = Console.ReadLine();
            Console.WriteLine(ReadFile(filePath));
        }

        public static string ReadFile(string path)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), path);
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return "File does not exist";
            }
        }

        public static void RemoveFileOrDirPrompt()
        {
            Console.Write("To delete dir: dirname/\n" +
                          "To delete file: filename\n" +
                          "File/Dir name to delete: ");
            string path = Console.ReadLine();

            if (path.EndsWith("/"))
            {
                DirectoryOperations.RemoveDir(path);
            }
            else
            {
                RemoveFile(path);
            }
        }

        public static void RemoveFile(string path)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), path);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public static void MoveFileOrDirPrompt()
        {
            Console.Write("To move dir: dirname/\n" +
                          "Enter whole path to destination folder\n" +
                          "To move file: filename\n" +
                          "File/Dir name to move: ");
            string path = Console.ReadLine();

            if (path.EndsWith("/"))
            {
                DirectoryOperations.MoveDirPrompt(path);
            }
            else
            {
                MoveFilePrompt(path);
            }
        }

        public static void MoveFilePrompt(string sourcePath)
        {
            Console.Write("Destination directory: ");
            string destinationPath = Console.ReadLine();
            MoveFile(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));
        }

        public static void MoveFile(string sourcePath, string destinationPath)
        {
            sourcePath = Path.Combine(Directory.GetCurrentDirectory(), sourcePath);
            if (File.Exists(sourcePath))
            {
                if (!File.Exists(destinationPath))
                {
                    File.Move(sourcePath, destinationPath);
                    Console.WriteLine("Moved");
                }
                else
                {
                    Console.WriteLine("Destination file already exists!");
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public static void CopyFileOrDirPrompt()
        {
            Console.Write("To copy dir: dirname/\n" +
                          "Enter a folder that does not yet exist, it create automatically\n" +
                          "Dir content copying to a new dir\n" +
                          "To copy file: filename\n" +
                          "File/Dir name to copy: ");
            string path = Console.ReadLine();

            if (path.EndsWith("/"))
            {
                DirectoryOperations.CopyDirPrompt(path);
            }
            else
            {
                CopyFilePrompt(path);
            }
        }

        public static void CopyFilePrompt(string sourcePath)
        {
            Console.Write("Destination directory: ");
            string destinationPath = Console.ReadLine();
            CopyFile(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));
        }

        public static void CopyFile(string sourcePath, string destinationPath)
        {
            sourcePath = Path.Combine(Directory.GetCurrentDirectory(), sourcePath);
            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }


        public static void GetFileInfoOrDirInfoPrompt()
        {
            Console.Write("To get dir info: dirname/\n" +
                          "To get file info: filename\n" +
                          "File/Dir name to get info: ");
            string path = Console.ReadLine();

            if (path.EndsWith("/"))
            {
                DirectoryOperations.GetDirInfoPrompt(path);
            }
            else
            {
                GetFileInfoPrompt(path);
            }
        }

        public static void GetFileInfoPrompt(string path)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), path);
            if (File.Exists(path))
            {
                var info = new FileInfo(path);
                Console.WriteLine($"-----File Info-----\n" +
                                  $"Name: {info.Name}\n" +
                                  $"Directory: {info.Directory}\n" +
                                  $"Extension: {info.Extension}\n" +
                                  $"Creation time: {info.CreationTime}\n" +
                                  $"Last write time: {info.LastWriteTime}\n" +
                                  $"Length: {info.Length} bytes\n");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}


