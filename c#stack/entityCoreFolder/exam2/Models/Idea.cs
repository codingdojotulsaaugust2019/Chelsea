using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace exam2.Models
{
    public class Idea
    {
        [Key]
        public int IdeaId {get;set;}

        [MinLength(20)]
        [Required]
        public string Content {get;set;}

        public int UserId {get;set;}

        public User Creator {get;set;}

        public List<Like> Likes {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
    }

}