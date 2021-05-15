using System;

namespace eo
{
    public sealed class FareWell
    {
        private Attempts _attempts;
        public FareWell(Attempts attempts)
        {
            _attempts = attempts;
        }

        public void Say()
        {
            _attempts.run();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Спасибо за игру!");
            Console.ResetColor();
        }
    }
}