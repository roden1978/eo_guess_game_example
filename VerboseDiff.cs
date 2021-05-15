namespace eo
{
    public sealed class VerboseDiff : IString
    {
        private string _str;
        private readonly IInteger _diff;

        public VerboseDiff(IInteger diff)
        {
            _diff = diff;
        }

        public string value()
        {
            var d = _diff.Value();

            if (d > 0)
            {
                _str = "Слишком маленькое число!\n";
            }
            else if (d < 0)
            {
                _str = "Слишком большое число!\n";
            }
            else
            {
                _str = "";
            }

            return _str;
        }
    }
}