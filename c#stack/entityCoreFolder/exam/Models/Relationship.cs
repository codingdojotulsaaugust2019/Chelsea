using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    
namespace exam.Models
{
    public class Relationship
    {
        [Key]
        public int RelationshipId { get; set; }

        public bool Accepted {get;set;} = false;
 
        public int SenderId { get; set; }
        public User Sender { get; set; }
 
        public int TargetId { get; set; }
        public User Target { get; set; }
    }
}