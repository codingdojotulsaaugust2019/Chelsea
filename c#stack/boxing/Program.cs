using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> objects = new List<Object>();
            objects.Add(7);
            objects.Add(28);
            objects.Add(-1);
            objects.Add(true);
            objects.Add("Chair");

            foreach( Object thing in objects)
            {
               if (thing is string)
               {
                   Console.WriteLine(thing);
               } 
               if (thing is int)
               {
                   Console.WriteLine(thing);
               }
               if (thing is bool)
               {
                   Console.WriteLine(thing);
               }
            }
            int sum = 0;
            foreach (Object thing in objects)
            {
                if (thing is int)
                {   int thing2;
                    thing2 = (int)thing;
                    sum = sum + thing2;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
