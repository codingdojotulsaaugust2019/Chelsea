using System;

namespace human
{
    public abstract class Person
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;

        public Person(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Person(string name, int strength, int intelligence, int dexterity, int healths)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = healths;
        }

        public virtual int Attack(Person target)
        {
            target.Health = target.Health - 5 * Strength;
            return target.Health;
        }
    }
}

