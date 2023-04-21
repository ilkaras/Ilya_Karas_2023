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
            Console.WriteLine("Name - Change date - Type - Creation time");

            foreach (var dir in dirs)
            {
                Console.WriteLine($"{dir.Name} - {dir.LastWriteTime} - Folder - {dir.CreationTime}");
            }

            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} - {file.LastWriteTime} - File - {file.CreationTime}");
            }

            Console.WriteLine("Type 'menu' - to see Menu /n" +
                              "or 'drives' - to see all drives ");
        }

        public static void ShowDrives()
        {
            var drives = DriveInfo.GetDrives();
            Console.WriteLine(" --- Drives --- ");
            foreach (var drive in drives)
            {
                Console.WriteLine($"-     {drive.Name}     -");
            }
            Console.WriteLine(" ------------- ");
        }

        public static void ChangeDirectory(string name)
        {
            if (name == "../")
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
            }
        }

        public static string GetUserInput()
        {
            Console.Write($"{Directory.GetCurrentDirectory()}>");
            string input = Console.ReadLine();
            return input;
        }

        public static void ChangeDirectoryOrShowMenu(string userInputPath)
        {
            switch (userInputPath)
            {
                case "menu":
                    Menu.ShowMenu();
                    break;
                case "drives":
                    ShowDrives();
                    break;
                default:
                    ChangeDirectory(userInputPath);
                    break;
            }
        }
    }
}