using System;

namespace eo
{
    public sealed class Secret : IInteger
    {
        private int _value;
       
        public int Value()
        {
           _value = _value == 0 ? 
                new Random().Next(1, 101) :
                _value;
            return _value;
        }
    }
}