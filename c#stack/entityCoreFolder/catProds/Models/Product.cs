using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace catProds.Models
    {
        public class Product
        {
            [Key]
            public int ProductId { get; set; }
            public string Name { get; set; }

            public string Description { get; set; }

            public decimal Price { get; set; }
            public List<Association> Categories {get;set;}
            public DateTime CreatedAt {get;set;} = DateTime.Now;

            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }