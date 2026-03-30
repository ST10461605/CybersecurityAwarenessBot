using System;
using System.Collections.Generic;

namespace CybersecurityAwarenessBot
{
    public static class ChatEngine
    {
        private static readonly Dictionary<string, string> Responses = new(StringComparer.OrdinalIgnoreCase)
        {
            // Casual / basic
            { "how are you", "I'm running at 100% uptime and ready to help! How are you feeling today?" },
            { "whats your purpose", "I'm here to teach South Africans how to recognise and avoid common cyber threats." },
            { "what can i ask", "Ask me about passwords, phishing, OTP scams, suspicious links, SARS fraud, banking safety, load-shedding tricks..." },

            // Cybersecurity topics
            { "password", "Use 14+ characters with uppercase, lowercase, numbers & symbols.\nGood example: MzansiR@1n2026!Coffee\nNever reuse passwords!" },
            { "phishing", "Fake messages pretending to be from trusted organisations. Very common in SA: fake Capitec/FNB alerts, SARS refunds." },
            { "link", "Rule #1: NEVER click links in unexpected SMS/emails.\nHover to check real URL or type it yourself." },
            { "otp", "Your bank will NEVER ask for your OTP over phone, email or WhatsApp. If someone asks → it's a scam." },
            { "sars", "SARS never requests banking details via email/WhatsApp. Only trust sars.gov.za. Report to phishing@sars.gov.za." },
            { "bank", "Use only official apps/websites. Ignore urgent 'account locked' or 'verify now' messages." },
            { "loadshedding", "Scammers exploit load-shedding: fake Eskom calls/SMS asking for meter numbers or banking info. Never share." },
            { "malware", "Don't open unknown email attachments. Avoid USBs found in public places. Fake Windows updates are common traps." },
            { "2fa", "Turn on two-factor authentication everywhere possible – especially email and banking apps." }
        };

        private static readonly string[] DailyTips = new[]
        {
            "Daily tip: Never share your OTP – not even with someone claiming to be from your bank.",
            "Daily tip: Check sender email addresses carefully – scammers use look-alike domains.",
            "Daily tip: Use a password manager instead of the same password everywhere.",
            "Daily tip: Keep your phone and computer updated – many exploits target outdated software.",
            "Daily tip: Be extra careful during load-shedding – criminals use power cuts to trick people."
        };

        public static void ShowRandomDailyTip()
        {
            var rand = new Random();
            string tip = DailyTips[rand.Next(DailyTips.Length)];

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("╔═══════════════════════ Daily Security Tip ═══════════════════════╗");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  {tip}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝\n");
            Console.ResetColor();
        }

        public static void RunChatLoop(string userName)
        {
            PrintDivider();
            ShowRandomDailyTip();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypewriterEffect.Typewrite($"{userName}: ", 25);
                Console.ResetColor();

                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypewriterEffect.Typewrite("I didn't catch that. Please type your question.\n", 35);
                    Console.ResetColor();
                    continue;
                }

                string lower = input.ToLowerInvariant();

                if (lower is "exit" or "quit" or "bye" or "goodbye")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    TypewriterEffect.Typewrite($"Goodbye, {userName}! Keep safe online.\n", 30);
                    Console.ResetColor();
                    break;
                }

                string response = GetResponse(lower);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Bot: ");
                Console.ResetColor();
                TypewriterEffect.Typewrite(response + "\n\n", 30);

                PrintDivider();
            }
        }

        private static string GetResponse(string input)
        {
            foreach (var kvp in Responses)
            {
                if (input.Contains(kvp.Key, StringComparison.OrdinalIgnoreCase))
                    return kvp.Value;
            }

            return "Sorry, I didn't understand that question.\n" +
                   "Try asking about passwords, phishing, OTP, SARS, banking or links.";
        }

        private static void PrintDivider()
        {
            UI.PrintDivider();
        }
    }
}