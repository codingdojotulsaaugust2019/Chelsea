using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            int[] array = new int[10];
            for (int i = 0; i<10; i++)
            {
                array[i]=i;
            }
            foreach (var entry in array)
            {
                Console.WriteLine(entry);
            }

            string[] names = {"Tim", "Martin", "Nikki","Sarah"};
            Console.WriteLine(names);
            foreach (var entry in names)
            {
                Console.WriteLine(entry);
            }

            string[] array1 = new string[10];
            for (int i = 0; i < 10; i=i+2)
            {
                    array1[i] = "True";
                    array1[i+1] = "False";
            }
            foreach (var entry in array1)
            {
                Console.WriteLine(entry);
            }

            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Coconut");
            flavors.Add("Lavendar");

            Console.WriteLine($"There are {flavors.Count} flavors in the list.");

            Console.WriteLine(flavors[2]);

            flavors.RemoveAt(2);

            Console.WriteLine($"The new list length is {flavors.Count}");

            Dictionary<string,string> users = new Dictionary<string, string>();
            Random rand = new Random();
            for(int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                string flav = flavors[rand.Next(0,4)];
                users.Add($"{name}",$"{flav}");
            }
            foreach (var entry in users)
            {
                Console.WriteLine($"{entry.Key}-{entry.Value}");
            }
            }
        }
    }