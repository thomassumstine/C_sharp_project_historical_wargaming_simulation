using System;

namespace AbstractInterfaceEx
{
    public abstract class Building : IStructuralDamage
    {
        public int Integrity { get; set; }
        public abstract string Type { get; set; }
        public virtual int TakeDamage(int amnt)
        {
            Integrity -= amnt; 
            Console.WriteLine($"{Type}'s structural integrity is: {Integrity}");
            return Integrity;
        }

        public Building()
        {
            Integrity = 300;
        }

    }
}
