using System.ComponentModel.DataAnnotations;

namespace Employee.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}