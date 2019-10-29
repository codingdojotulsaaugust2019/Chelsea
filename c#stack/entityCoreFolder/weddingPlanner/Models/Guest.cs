using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace weddingPlanner.Models
{
    public class Guest
    {
        [Key]
        public int GuestId {get;set;}

        public int WeddingId {get;set;}

        public int UserId {get;set;}

        public User User {get;set;}

        public Wedding Wedding {get;set;}

        public DateTime RsvpAt = DateTime.Now;
    }


}