using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Zombie Cain = new Zombie ("Cain");
            Ninja Abel = new Ninja ("Abel");
            Wizard Merlin = new Wizard ("Merlin");
            Merlin.Attack(Cain);
            Cain.Meditate();
            Abel.Steal(Merlin);
            Cain.Attack(Merlin);
            Merlin.Heal(Merlin);
        }
    }
}