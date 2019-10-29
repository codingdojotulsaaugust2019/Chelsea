using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using System;

namespace pro_cat.Models
{
    public class Category{
        [Key]
        public int CatId { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set;}

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Association> CatProducts { get; set; }

    }
}

