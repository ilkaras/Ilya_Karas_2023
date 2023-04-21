namespace Lesson5
{
    public class Menu
    {
        public static void ShowMenu()
        {
            Console.Write("------- Menu -------\n" +
                          "1 - Read file            \n" +
                          "2 - Remove file/dir      \n" +
                          "3 - Move file/dir        \n" +
                          "4 - Copy file/dir        \n" +
                          "i - Info                 \n" +
                          "e - Quit                 \n" +
                          " -------------------\n" +
                          "Action: ");
            string input = Console.ReadLine();
            ProcessMenuInput(input);
        }

        public static void ProcessMenuInput(string input)
        {
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
                case "i":
                    FileOperations.GetFileInfoOrDirInfoPrompt();
                    break;
                case "e":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    ShowMenu();
                    break;
            }
        }
    }
}