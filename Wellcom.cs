using System;

namespace eo
{
    public sealed class Wellcom
    {
        private readonly Phrase _phrase;

        public Wellcom(Phrase phrase)
        {
            _phrase = phrase;
        }
        public void Say()
        {
            _phrase.Say();
        }
    }
}