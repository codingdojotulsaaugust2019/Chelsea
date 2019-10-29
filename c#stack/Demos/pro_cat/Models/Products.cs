using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using System;

namespace pro_cat.Models
{
    public class Product{
        [Key]
        public int ProdId { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set;}

        [Required]
        [MinLength(5)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Association> ProdCategories { get; set; }
        
    }
}

