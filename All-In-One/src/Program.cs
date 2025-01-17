using All_In_One.src.Utilities.Crawl;
using All_In_One.src.Utilities.Office_Windows;
using All_In_One.src.Utilities.SourceFile;
using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args) // Khai báo phương thức Main là đồng bộ
    {
        Encoding ascii = Encoding.ASCII;

        OW ow = new OW();
        FileExtention fileExtention = new FileExtention();

        while (true)
        {
            Console.Clear(); // Làm mới màn hình

            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;

            // Tạo menu dưới dạng mảng string
            string[] menuLines = {
                "            ALL TOOL IN ONE TOOL                      ",
                "------------------------------------------------------",
                "|  STATUS    |        NAME                    | YEAR |",
                "------------------------------------------------------",
                "[1] Active   | Active Windows / Office        | 2025 |",
                "[2] Active   | File Classification            | 2025 |",
                "[3] Active   | Crawl Data Facebook/Instagram  | 2025 |",
                "------------------------------------------------------",
                "Choose a menu option: "
            };
            int startY = (consoleHeight - menuLines.Length) / 2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < menuLines.Length - 1; i++)
            {
                string line = menuLines[i];
                int startX = (consoleWidth - line.Length) / 2;
                Console.SetCursorPosition(startX, startY + i);
                Console.WriteLine(line);
            }
            Console.ResetColor();

            Console.SetCursorPosition(
                (consoleWidth - menuLines[^1].Length) / 2,
                startY + menuLines.Length - 1);
            Console.Write(menuLines[^1]);

            string? choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("[1]. Active | Windows / Office | 2025 selected!");
                    ow.Active();
                    break;
                case "2":
                    Console.WriteLine("[2] Active | File Classification | 2025 selected!");
                    fileExtention.SourcFile();
                    break;
                case "3":
                    MenuCrawlDataFBINS();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice, please try again.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }

    public static void MenuCrawlDataFBINS()
    {
        string[] menuFbIg = {
            "            ALL TOOL IN ONE TOOL                      ",
            "------------------------------------------------------",
            "|  STATUS    |        NAME                    | YEAR |",
            "------------------------------------------------------",
            "[1] Active   | Crawl My Friend                | 2025 |",
            "------------------------------------------------------",
            "Choose a menu option: "
        };

        int consoleWidth = Console.WindowWidth;
        int consoleHeight = Console.WindowHeight;

        int startY = (consoleHeight - menuFbIg.Length) / 2;
        Crawl crawl = new Crawl();
        Console.ForegroundColor = ConsoleColor.Cyan;
        for (int i = 0; i < menuFbIg.Length - 1; i++)
        {
            string line = menuFbIg[i];
            int startX = (consoleWidth - line.Length) / 2;
            Console.SetCursorPosition(startX, startY + i);
            Console.WriteLine(line);
        }
        Console.ResetColor();

        // Vị trí lựa chọn
        Console.SetCursorPosition(
            (consoleWidth - menuFbIg[^1].Length) / 2,
            startY + menuFbIg.Length - 1);
        Console.Write(menuFbIg[^1]);

        string? choice = Console.ReadLine();
        Console.Clear();

        // Xử lý lựa chọn của người dùng
        switch (choice)
        {
            case "1":
                //Console.WriteLine("[1] Active   | Crawl My Friend | 2025 selected!");
                crawl.GetData();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice, please try again.");
                Console.ResetColor();
                break;
        }

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}
