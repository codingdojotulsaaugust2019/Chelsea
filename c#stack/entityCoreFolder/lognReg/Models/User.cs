using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    
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

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    [NotMapped]
    [Compare("Password", ErrorMessage="Passwords do not match, try again!")]
    [DataType(DataType.Password)]
    public string Confirm {get;set;}
}    
