using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZombieProject.Models;
    
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

    [Required]
    public string Gender {get;set;}

    [Required]
    [LegalAge]
    public DateTime Birthday {get;set;}

    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    public string Password {get;set;}

    [InverseProperty("Sender")]
    public List<Message> ISentTo {get;set;} = new List<Message>();

    [InverseProperty("Target")]
    public List<Message> IRecievedFrom {get;set;} = new List<Message>();

    [Required]
    [MinLength(50)]
    public string Description {get;set;}

    [Required]
    [MaxLength(180)]
    public string Tagline {get;set;}

    public string Hobbies {get;set;}

    [Required]
    public string InterestedIn {get;set;}

    public string City {get;set;}

    public string ImageURL {get;set;}

    [Required]
    [MaxLength(2)]
    [MinLength(2)]
    public string State {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    [NotMapped]
    [Compare("Password", ErrorMessage="Passwords do not match, try again!")]
    [DataType(DataType.Password)]
    public string Confirm {get;set;}
}    
