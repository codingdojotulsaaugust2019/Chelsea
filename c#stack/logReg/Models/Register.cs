using System.ComponentModel.DataAnnotations;

namespace logReg.Models
{
    public class Register
    {
        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string LastName {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8)]
        [Compare("cPassword", ErrorMessage="Passwords must match.")]
        public string Password {get;set;}

        [Required]
        [Display(Name="Confirm Pasword")]
        public string cPassword {get;set;}
    }
}