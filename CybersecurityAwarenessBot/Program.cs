using System;

namespace CybersecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot – South Africa";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            // 1. Voice greeting
            Greeting.PlayVoiceGreeting();

            // 2. ASCII header
            UI.DisplayHeader();

            // Divider
            UI.PrintDivider();

            // 3. Get valid name
            string userName = Greeting.GetUserName();

            // 4. Start main chat
            ChatEngine.RunChatLoop(userName);

            // Farewell
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThank you for using the Cybersecurity Awareness Bot, {userName}! Stay safe online. 🇿🇦");
            Console.ResetColor();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}