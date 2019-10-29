using System.ComponentModel.DataAnnotations;
using System;


namespace chefNdish.Models
{
    public class PastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DateTime birthday = (DateTime)value;

            DateTime present = DateTime.Now; 

            TimeSpan interval = present - birthday;

            if (interval.Days < 6570)
            {
                return new ValidationResult("You must be at least 18 years old.");
            }

            int result = DateTime.Compare(birthday, present);

            if (result > 0)
                return new ValidationResult("Cannot enter a date in the future.");
                
            return ValidationResult.Success;
        }
    }

}