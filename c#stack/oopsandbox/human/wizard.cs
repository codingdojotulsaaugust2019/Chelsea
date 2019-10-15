using System;

namespace human
{
    public class Wizard : Person
    {
        public Wizard (string name) : base(name)
        {
             Health = 50;
             Intelligence = 25;
        }

        public override int Attack(Person target)
        {
            target.Health = target.Health - 5 * target.Intelligence;
            this.Health = 5 * target.Intelligence;
            return target.Health;
        }

        public int Heal (Person target)
        {
            target.Health = 10 * target.Intelligence;
            return target.Health;
        }
    }
} 