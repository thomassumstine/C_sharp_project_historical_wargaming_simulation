using System;

namespace AbstractInterfaceEx
{
    public abstract class Carthaginian_Army : ICasualties
    {
        public int Composition { get; set; }
        public abstract string Type { get; set; }
        public virtual int SufferCasualties(int amnt)
        {
            Composition -= amnt; 
            Console.WriteLine($"{Type}'s composition is: {Composition}");
            return Composition;
        }

        public Carthaginian_Army()
        {
            Composition = 49500;
        }

    }
}
