namespace eo
{
    public sealed class Diff: IInteger
    {
        private readonly IInteger _guess;
        private readonly IInteger _secret;
        public Diff(IInteger guess, IInteger secret)
        {
            _guess = guess;
            _secret = secret;
        }

        public int Value()
        {
            return _secret.Value() - _guess.Value();
        }
    }
}