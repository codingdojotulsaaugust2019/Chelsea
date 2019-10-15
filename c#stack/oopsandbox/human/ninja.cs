using System;

namespace human
{
    public class Ninja : Person
    {
        public Ninja (string name) : base(name)
        {
             Dexterity = 50;
        }

        public override int Attack(Person target)
        {
            target.Health = target.Health - 5 * target.Dexterity;
            Random rand = new Random();
            int x = rand.Next(0,4);
                if (x == 0)
                {
                    target.Health -= 10;
                }
            return target.Health;
        }

        public void Steal(Person target)
        {
            target.Health -= 5;
            this.Health += 5;
        }

    }
} 