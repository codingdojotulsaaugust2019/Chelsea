using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using System;

namespace pro_cat.Models
{
    public class Association{
        [Key]
        public int AssId { get; set; }

        public int ProdId {get; set; }

        public int CatId { get; set; }

        public Category Category { get; set; }

        public Product Product { get; set; }
        
    }
}

