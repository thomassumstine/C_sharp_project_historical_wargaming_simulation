using System;

namespace AbstractInterfaceEx
{
    public class Hero : IFatality
    {
        public int Vitality { get; set; }
        public string Name { get; set; }
        private bool _isShielded;
        public bool IsShielded
        {
            get { return _isShielded; }
        }

        public Hero(string name)
        {
            Name = name;
            Vitality = 1;
        }

        public void Attack(IFatality target)
        {
            target.FatallyInjured(1);
        }


        public int FatallyInjured(int amnt)
        {
            if(_isShielded == true)
            {
                _isShielded = false;
            }
            else
            {
                Vitality -= amnt;
            }
            if (Vitality == 0)
            {
                _isShielded = true;
            }
            Console.WriteLine($"{Name}'s vitality is: {this.Vitality}");
            return Vitality;
        }
    }
}

//Console.WriteLine($"shield {_isShielded}");
//            if(_isShielded == true)
//            {
//                _isShielded = false;
//                Console.WriteLine("should be false");
//            }
//            else
//            {
//               Vitality -= amnt;
//            }
//            if (Vitality <= 1 )
//            {
//                _isShielded = true;
//            }
//            if(_isShielded == true && Vitality <= 1)
//            {
//                _isShielded = false;
//                Console.WriteLine("should be false");
//            }


//            Console.WriteLine($"{Name}'s vitality is: {this.Vitality}");
//            return Vitality;

//if (Vitality == 2)
//            {
//                _isShielded = true;
//                if(_isShielded == true)
//                {
//                    _isShielded = false;
//                }
//            }
//            else if (Vitality == 1)
//            {
//                _isShielded = true;
//                if(_isShielded == true)
//                {
//                    _isShielded = false;
//                }
//            }
//            else
//            {
//                Vitality -= amnt;
//            }
//            Console.WriteLine($"{Name}'s vitality is: {this.Vitality}");
//            return Vitality;