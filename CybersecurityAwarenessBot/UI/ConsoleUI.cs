namespace CybersecurityAwarenessBot.UI;

public static class ConsoleUI
{
    public static void ShowTitle()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("==================================================");
        Console.WriteLine("          CYBERSECURITY AWARENESS BOT            ");
        Console.WriteLine("==================================================");

        Console.ResetColor();

        ShowAsciiArt();

        Console.WriteLine();
    }

    public static void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"");
        Console.WriteLine(@"      .-----------------------------.");
        Console.WriteLine(@"      |       CYBER SECURITY        |");
        Console.WriteLine(@"      |          _______            |");
        Console.WriteLine(@"      |         /       \           |");
        Console.WriteLine(@"      |        |  LOCK   |          |");
        Console.WriteLine(@"      |        |_________|          |");
        Console.WriteLine(@"      |       STAY SAFE ONLINE      |");
        Console.WriteLine(@"      '-----------------------------.'");

        Console.ResetColor();
    }

    public static void ShowBotMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("BOT: " + message);
        Console.ResetColor();
    }

    public static void ShowUserPrompt()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("YOU: ");
        Console.ResetColor();
    }

    public static void TypeMessage(string message, int delay = 15)
    {
        foreach (char character in message)
        {
            Console.Write(character);
            Thread.Sleep(delay);
        }

        Console.WriteLine();
    }

    public static void ShowDivider()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("--------------------------------------------------");
        Console.ResetColor();
    }
}
