using System.Media;
using CybersecurityAwarenessBot.Models;
using CybersecurityAwarenessBot.Services;
using CybersecurityAwarenessBot.UI;

namespace CybersecurityAwarenessBot;

public class Program
{
    public static void Main()
    {
        PlayVoiceGreeting();

        ConsoleUI.ShowTitle();

        ConsoleUI.ShowBotMessage(
            "Welcome to the Cybersecurity Awareness Bot!"
        );

        ConsoleUI.ShowDivider();

        ConsoleUI.ShowBotMessage(
            "Before we begin, what is your name?"
        );

        ConsoleUI.ShowUserPrompt();

        string? name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter your name.");
            Console.ResetColor();

            ConsoleUI.ShowUserPrompt();
            name = Console.ReadLine();
        }

        UserProfile user = new UserProfile
        {
            Name = name.Trim()
        };

        Chatbot chatbot = new Chatbot(user);

        ConsoleUI.ShowDivider();

        ConsoleUI.ShowBotMessage(
            $"Nice to meet you, {user.Name}!"
        );

        ConsoleUI.ShowBotMessage(
            "You can ask me about passwords, phishing, safe browsing, suspicious links or malware."
        );

        ConsoleUI.ShowDivider();

        while (true)
        {
            ConsoleUI.ShowUserPrompt();

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                ConsoleUI.ShowBotMessage(
                    "Please type a question so I can help you."
                );

                continue;
            }

            if (input.Trim().Equals("exit",
                StringComparison.OrdinalIgnoreCase))
            {
                ConsoleUI.ShowBotMessage(
                    $"Goodbye, {user.Name}! Stay safe online."
                );

                break;
            }

            string response = chatbot.GetResponse(input);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("BOT: ");
            Console.ResetColor();

            ConsoleUI.TypeMessage(response);

            ConsoleUI.ShowDivider();
        }
    }

    private static void PlayVoiceGreeting()
    {
        try
        {
            string audioPath = Path.Combine(
                AppContext.BaseDirectory,
                "Assets",
                "voice_greeting.wav.mp4.wav"
            );

            if (File.Exists(audioPath))
            {
                using SoundPlayer player = new SoundPlayer(audioPath);
                player.PlaySync();
            }
        }
        catch (Exception)
        {
            Console.WriteLine(
                "Voice greeting could not be played."
            );
        }
    }
}
