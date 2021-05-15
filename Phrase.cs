using System;

namespace eo
{
    public sealed class Phrase
    {
        private readonly string _str;
        private readonly ConsoleColor _color;
        
        public Phrase(string str)
        {
            _str = str;
        }

        public Phrase(string str, ConsoleColor color)
        {
            _str = str;
            _color = color;
        }

        public void Say()
        {
            Console.ForegroundColor = _color;
            Console.WriteLine(_str);
            Console.ResetColor();
        }
    }
}