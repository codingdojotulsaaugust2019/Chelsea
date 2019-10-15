using System.ComponentModel.DataAnnotations;
namespace dojoSurvey2.Models
{
    public class Ninja
    {
        [Required]
        [MinLength(2)]
        public string Name {get;set;}

        [Required]
        public string Location {get;set;}

        [Required]
        public string Language {get;set;}

        [MinLength(20)]
        public string Comment {get;set;}
    }

}
