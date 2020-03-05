using System;

namespace AbstractInterfaceEx
{
    public class Socii_Infantry  : Roman_Army
    {
        public override string Type { get; set; }

        private bool _isShielded;
        public bool IsShielded
        {
            get { return _isShielded; }
        }

        public Socii_Infantry (string type)
        {
            Composition = 40000;
            Type = type;
        }

        public void Attack(ICasualties target)
        {
            target.SufferCasualties(100);
        }

        public override int SufferCasualties(int amnt)
        {
            if(_isShielded == true)
            {
                _isShielded = false;
            }
            else
            {
                Composition -= amnt;
            }
            if (Composition == 0)
            {
                _isShielded = true;
            }
            Console.WriteLine($"{Type}'s composition is: {Composition}");
            return Composition;
        }
    }
}
