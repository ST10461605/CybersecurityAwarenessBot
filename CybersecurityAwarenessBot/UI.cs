using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public static class UI
    {
        public static void DisplayHeader()
        {
            string[] logo = new[]
            {
                "   ▄████████  ▄█        ▄█           ███      ▄██████▄   ▄█  ███    █▄     ▄████████    ▄████████ ",
                "  ███    ███ ███       ███       ▀█████████▄ ███    ███ ███  ███    ███   ███    ███   ███    ███ ",
                "  ███    █▀  ███       ███          ▀███▀▀███ ███    ███ ███  ███    ███   ███    █▀    ███    █▀  ",
                " ▄███▄▄▄     ███       ███           ███   ▀███ ███    ███ ███ ▄███▄▄▄▄██▀  ▄███▄▄▄      ▄███▄▄▄     ",
                "▀▀███▀▀▀     ███       ███           ███    ███ ███    ███ ███ ▀▀███▀▀▀▀▀   ▀▀███▀▀▀     ▀▀███▀▀▀     ",
                "  ███    █▄  ███       ███           ███    ███ ███    ███ ███ ▀███████████   ███    █▄    ███    █▄  ",
                "  ███    ███ ███▌    ▄ ███▌    ▄     ███   ▄███ ███    ███ ███   ███    ███   ███    ███   ███    ███ ",
                "  ██████████ █████▄▄██ █████▄▄██   ▄█████████▀   ▀██████▀  █▀    ███    ███   ██████████   ██████████ ",
                "             ▀         ▀                                                                                 ",
                "                          Cybersecurity Awareness Bot – Stay Protected Online!                          ",
                "═══════════════════════════════════════════════════════════════════════════════════════════════════════════"
            };

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var line in logo.Take(logo.Length - 2))
            {
                Console.WriteLine(line);
                Thread.Sleep(20);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(logo[^2]);   // Now includes "– Stay Protected Online! 🇿🇦"
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(logo[^1]);

            Console.ResetColor();
            Console.WriteLine();
        }

        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("───────────────────────────── 💻 Cyber Safe Zone ─────────────────────────────");
            Console.ResetColor();
        }
    }
}