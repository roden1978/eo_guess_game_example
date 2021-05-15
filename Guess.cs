using System;
namespace eo
{
    public class Guess : IInteger
    {
        private readonly Wellcom _wellcom;
        public Guess(Wellcom wellcom){
            _wellcom = wellcom;
        }
        public int Value()
        {
            _wellcom.Say();
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}