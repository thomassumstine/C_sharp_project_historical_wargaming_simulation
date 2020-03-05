using System;

namespace AbstractInterfaceEx
{
    public interface IStructuralDamage
    {
        int Integrity { get; set; }
        int TakeDamage(int amnt);
    }
    
    public interface IFatality
    {
        int Vitality { get; set; }
        int FatallyInjured(int amnt);
    }

    public interface ICasualties
    {
        int Composition { get; set; }
        int SufferCasualties(int amnt);
    }
}
