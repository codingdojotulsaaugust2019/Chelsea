using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    
namespace exam2.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2)]
        [RegularExpression(@"^[a-z][a-z\s]*$", 
         ErrorMessage = "Letters and spaces only.")]
        public string Name {get;set;}

        [Required]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z0-9]+$", 
         ErrorMessage = "Letters & numbers only.")]
        public string Alias {get;set;}

        [EmailAddress]
        [Required]
        public string Email {get;set;}

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password {get;set;}

        public List<Idea> Ideas {get;set;} = new List<Idea>();

        public List<Like> Likes {get;set;} = new List<Like>();

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password", ErrorMessage="Passwords do not match, try again!")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }    
}
