using System.ComponentModel.DataAnnotations;
namespace logReg.Models


{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(1)]
        public string Password {get;set;}
    }
}