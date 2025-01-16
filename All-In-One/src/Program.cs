using System;

internal class Program
{
    private static async Task Main(string[] args)
    {
        int consoleWidth = Console.WindowWidth;
        int consoleHeight = Console.WindowHeight;

        string title = "Welcome to the Tool Aggregator";
        string[] options = {
            "1. Open Tool 1",
            "2. Open Tool 2",
            "3. Open Tool 3",
            "4. Settings",
            "5. Exit"
        };

        int titlePositionX = (consoleWidth - title.Length) / 2;
        int titlePositionY = consoleHeight / 4;

        Console.SetCursorPosition(titlePositionX, titlePositionY);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(title);
        Console.ResetColor();

        int optionPositionY = titlePositionY + 2;
        foreach (var option in options)
        {
            int optionPositionX = (consoleWidth - option.Length) / 2;
            Console.SetCursorPosition(optionPositionX, optionPositionY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(option);
            optionPositionY++;
        }

        Console.ResetColor();
        bool exit = false;

        while (!exit)
        {
            Console.SetCursorPosition((consoleWidth - "Enter your choice (1-5): ".Length) / 2, consoleHeight - 3);
            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.SetCursorPosition((consoleWidth - "Tool 1 opened!".Length) / 2, consoleHeight - 2);
                    Console.WriteLine("Tool 1 opened!");
                    break;
                case "2":
                    Console.SetCursorPosition((consoleWidth - "Tool 2 opened!".Length) / 2, consoleHeight - 2);
                    Console.WriteLine("Tool 2 opened!");
                    break;
                case "3":
                    Console.SetCursorPosition((consoleWidth - "Tool 3 opened!".Length) / 2, consoleHeight - 2);
                    Console.WriteLine("Tool 3 opened!");
                    break;
                case "4":
                    Console.SetCursorPosition((consoleWidth - "Settings menu opened!".Length) / 2, consoleHeight - 2);
                    Console.WriteLine("Settings menu opened!");
                    break;
                case "5":
                    Console.SetCursorPosition((consoleWidth - "Exiting...".Length) / 2, consoleHeight - 2);
                    Console.WriteLine("Exiting...");
                    exit = true;
                    break;
                default:
                    Console.SetCursorPosition((consoleWidth - "Invalid choice, please try again.".Length) / 2, consoleHeight - 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice, please try again.");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
