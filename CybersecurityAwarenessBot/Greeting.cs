using System;
using System.Linq;
using System.Media;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public static class Greeting
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                using var player = new SoundPlayer("Assets/greeting.wav");
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"[Voice greeting unavailable: {ex.Message}]");
                Console.ResetColor();
            }
        }

        public static string GetUserName()
        {
            string name;

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypewriterEffect.Typewrite("Hello and welcome to the Cybersecurity Awareness Bot!\n\n", 35);
            Console.ResetColor();

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypewriterEffect.Typewrite("What's your name? ", 40);
                Console.ResetColor();

                name = Console.ReadLine()?.Trim() ?? "";

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypewriterEffect.Typewrite("Please enter a name (cannot be empty).\n", 35);
                    Console.ResetColor();
                    continue;
                }

                if (name.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypewriterEffect.Typewrite("Name must be at least 2 characters long.\n", 35);
                    Console.ResetColor();
                    continue;
                }

                if (name.All(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypewriterEffect.Typewrite("Names usually contain letters. Please try again.\n", 35);
                    Console.ResetColor();
                    continue;
                }

                // Very basic spam/repeat check
                if (name.Length > 5 && name.Distinct().Count() <= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypewriterEffect.Typewrite("That looks like a repeated pattern. Please enter a real name.\n", 35);
                    Console.ResetColor();
                    continue;
                }

                break;

            } while (true);

            Console.ForegroundColor = ConsoleColor.Green;
            TypewriterEffect.Typewrite($"\nWelcome, {name}! I'm here to help you stay safe online.\n\n", 30);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            TypewriterEffect.Typewrite("You can ask about:\n", 30);
            Console.ForegroundColor = ConsoleColor.Magenta;
            TypewriterEffect.Typewrite(
                " • strong passwords\n" +
                " • phishing emails / SMS\n" +
                " • suspicious links\n" +
                " • OTP scams\n" +
                " • SARS scams\n" +
                " • safe banking\n" +
                " • load-shedding tricks\n\n", 30);
            Console.ResetColor();

            return name;
        }
    }
}