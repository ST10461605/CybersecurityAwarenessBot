using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public static class TypewriterEffect
    {
        public static void Typewrite(string text, int delayMs = 35)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
        }
    }
}