using System;

namespace AbstractInterfaceEx
{
    public class Defenses : Building
    {
        public override string Type { get; set; }

        private bool _isShielded;
        public bool IsShielded
        {
            get { return _isShielded; }
        }

        public Defenses(string type)
        {
            Integrity = 400;
            Type = type;
        }

        public void Attack(ICasualties target)
        {
            target.SufferCasualties(100);
        }

        public override int TakeDamage(int amnt)
        {
            if(_isShielded == true)
            {
                _isShielded = false;
            }
            else
            {
                Integrity -= amnt;
            }
            if (Integrity == 0)
            {
                _isShielded = true;
            }
            Console.WriteLine($"{Type}'s structural integrity is: {Integrity}");
            return Integrity;
        }
    }
}
