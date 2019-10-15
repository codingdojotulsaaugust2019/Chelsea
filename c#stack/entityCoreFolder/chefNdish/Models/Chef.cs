using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    
namespace chefNdish.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}

        [Required]
        [PastDate]
        public DateTime Birthday {get;set;}

        public List<Dish> CreatedDishes {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}
