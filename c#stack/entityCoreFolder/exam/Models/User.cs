using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    
namespace exam.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}

        [EmailAddress]
        [Required]
        public string Email {get;set;}

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password {get;set;}

        [Required]
        [MinLength(20)]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        //**************************************** MANY TO MANY NAVIGATIONS *************************************************/

        //I want a list of relationships where another user sent me a request - I am the target.
        [InverseProperty("Target")]
        public List<Relationship> RequestedMe { get; set; } = new List<Relationship>();

 
        //I want a list of all the users I sent a request to - I am the sender.
        [InverseProperty("Sender")]
        public List<Relationship> IRequested { get; set; } = new List<Relationship>();

        //*******************************************************************************************************************/

        [NotMapped]
        [Compare("Password", ErrorMessage="Passwords do not match, try again!")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }    

}
