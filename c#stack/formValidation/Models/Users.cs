using System.ComponentModel.DataAnnotations;
using System;

namespace formValidation.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string FirstName {get;set;}

        [Required]
        [MinLength(4)]
        public string LastName {get;set;}

        [Required]
        [Range(0,200)]
        public int Age {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [Required]
        [FutureDate]
        public DateTime Date {get;set;}
    }
}