using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace weddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}

        [Required]
        public string Wedder1 {get;set;}


        [Required]
        public string Wedder2 {get;set;}

        [Required]
        public int UserId {get;set;}

        public User Planner {get;set;}

        [Required]
        public string Address {get;set;}

        [Required]
        public DateTime Date {get;set;}

        public List<Guest> Guests {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

    }

}