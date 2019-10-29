using System;
using System.ComponentModel.DataAnnotations;

namespace exam2.Models
{
    public class Like
    {
        [Key]
        public int LikeId {get;set;}

        public int UserId {get;set;}
        public User Liker {get;set;}

        public int IdeaId {get;set;}
        public Idea Idea {get;set;}

        public DateTime CreatedAt = DateTime.Now;
    }
}