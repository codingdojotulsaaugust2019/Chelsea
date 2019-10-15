using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?

            Artist buddy = Artists.SingleOrDefault(person => person.Hometown =="Mount Vernon");
            Console.WriteLine(buddy.RealName);
            Console.WriteLine(buddy.Age);

            //Who is the youngest artist in our collection of artists?

            IEnumerable<Artist> orderedAges = Artists.OrderBy(person =>person.Age);
            Artist youngBuddy = orderedAges.FirstOrDefault();

            Console.WriteLine($"{youngBuddy.ArtistName} is from {youngBuddy.Hometown}, but their real name is {youngBuddy.RealName} and they are {youngBuddy.Age} years old, making them the youngest on the list.");

            //Display all artists with 'William' somewhere in their real name

            IEnumerable<Artist> WhereMyWillies = Artists.Where(pal => pal.RealName.Contains("William"));
            foreach (Artist willy in WhereMyWillies)
            {
                Console.WriteLine($"{willy.ArtistName}'s real name is {willy.RealName}.");
            }

            //Display the 3 oldest artist from Atlanta

            IEnumerable<Artist> elders = Artists.Where(person => person.Hometown =="Atlanta");
            IEnumerable<Artist> orderedElders = elders.OrderByDescending(dude => dude.Age);
            IEnumerable<Artist> takenElders = orderedElders.Take(3);
            foreach (Artist eldie in takenElders)
            {
                Console.WriteLine($"My name is {eldie.RealName} and I am {eldie.Age} years old.");
            }

            //Display all groups with names less than 8 characters in length.

            IEnumerable<Group> groups = Groups.Where(grp => grp.GroupName.Length < 8);
            foreach (Group g in groups)
            {
                Console.WriteLine($"The length of this group name, {g.GroupName}, is less than 8 characters.");
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
	        Console.WriteLine(Groups.Count);
        }
    }
}
