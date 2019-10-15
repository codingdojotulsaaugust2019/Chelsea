using System;
using System.Collections.Generic;

class Buffet
    {
        public List<IConsumable> Menu;
        
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Mac N Cheese", 200, false, false),
                new Food("Pizza", 300, true, true),
                new Food("Salad", 300, false, false),
                new Food("Kung Pao Chicken", 200, true, true),
                new Food("Wings", 200, true, false),
                new Food("Waffles", 400, false, true),
                new Food("Ice Cream", 200, false, true),
                new Drink("Mexican Hot Coco", 70, true, false),
                new Drink("Lemonade", 70, false, true)
            };
        }
         
        Random rand = new Random();
        public IConsumable Serve()
        {
            IConsumable served = Menu[rand.Next(0,6)];
            return served;
        }
    }