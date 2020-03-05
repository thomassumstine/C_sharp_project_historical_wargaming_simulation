using System;

namespace AbstractInterfaceEx
{
    public class Libyan_Pheonecian_Cavalry: Carthaginian_Army
    {
        public override string Type { get; set; }

        private bool _isShielded;
        public bool IsShielded
        {
            get { return _isShielded; }
        }

        public Libyan_Pheonecian_Cavalry(string type)
        {
            Composition = 450;
            Type = type;
        }

        public void Attack(ICasualties target)
        {
            target.SufferCasualties(130);
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
