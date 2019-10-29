using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieProject.Models
{
    public class LoginUser
    {
    [Required]
    [Display(Name = "Email")]
    [MinLength(2, ErrorMessage="Please enter an email.")]
    public string lEmail {get; set;}

    [Required]
    [Display(Name = "Password")]
    [MinLength(2, ErrorMessage="Please enter a password.")]
    public string lPassword { get; set; }
    }
}