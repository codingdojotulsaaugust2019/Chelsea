using System;

namespace human
{
    public class Zombie : Person
    {
        public Zombie (string name) : base(name)
        {
             Health = 200;
        }

        public new int Attack(Person target)
        {
            if (target.Health < 50)
            {
                target.Health = 0;
            }
            return target.Health;
        }

        public void Meditate()
        {
            this.Health = 200;
        }
    }
} 