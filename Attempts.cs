using System;

namespace eo
{
    public sealed class Attempts
    {
        private readonly Action<Secret, int> _action;
        private readonly Secret _secret;
        public Attempts(Action<Secret, int> action, Secret secret)
        {
            _action = action;
            _secret = secret;
        }

        public void run()
        {
           _action?.Invoke(_secret, 5); 
        }
       
    }
}