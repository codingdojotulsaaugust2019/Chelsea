using System.ComponentModel.DataAnnotations;
using System;



namespace formValidation.Models
{
    public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {

        DateTime inputdate = (DateTime)value;

        DateTime present = DateTime.Now; 

        int result = DateTime.Compare(inputdate, present);

        if (result < 0)
            return new ValidationResult("Cannot enter a date in the past.");
        return ValidationResult.Success;
    }
}

}