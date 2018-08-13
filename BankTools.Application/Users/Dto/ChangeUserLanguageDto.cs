using System.ComponentModel.DataAnnotations;

namespace BankTools.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}