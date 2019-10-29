using System.Collections.Generic;

namespace pro_cat.Models
{
    public class ProductView
    {
        public Product ShowProduct {get; set;}
        public List<Category> UnaddedCategories {get; set;}
        public Association Association { get; set; }
    }
}