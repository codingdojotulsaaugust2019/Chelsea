using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace bankAccounts.Models
    {
        public class User
        {
            [Key]
            public int UserId { get; set; }
            
            [Required]
            public string FirstName { get; set; }
            
            [Required]
            public string LastName { get; set; }
            
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            
            [NotMapped]
            [Compare("Password", ErrorMessage="Passwords do not match, try again.")]
            [DataType(DataType.Password)]
            public string cPassword { get; set; }

            public Decimal Balance {get;set;} = 0;

            public List<Transaction> Transactions {get;set;} = new List<Transaction>();
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }