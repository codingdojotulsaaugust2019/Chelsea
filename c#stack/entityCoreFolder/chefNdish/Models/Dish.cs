using System;
using System.ComponentModel.DataAnnotations;

namespace chefNdish.Models
    {
        public class Dish
        {

            [Key]
            public int DishId { get; set; }

            [Required]
            [MinLength(2)]
            public string Name { get; set; }

            [Required]
            public int Tastiness { get; set; }

            [Required]
            [Range(0,9999999)]
            public int Calories { get; set; }

            [Required]
            [MinLength(10)]
            public string Description { get; set; }

            [Required]
            public int ChefId {get; set;}

            public Chef Creator {get; set;}

            public DateTime CreatedAt {get;set;} = DateTime.Now;

            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }
    