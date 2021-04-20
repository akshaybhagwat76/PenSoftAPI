using System.ComponentModel.DataAnnotations;

namespace PenSoftAPI.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}