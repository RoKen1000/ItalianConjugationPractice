using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Models.ViewModels
{
    public abstract class BaseLanguageViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Infinitive { get; set; }
        [Required]
        public string FirstPersonSingular { get; set; }
        [Required]
        public string SecondPersonSingular { get; set; }
        [Required]
        public string ThirdPersonSingular { get; set; }
        [Required]
        public string FirstPersonPlural { get; set; }
        [Required]
        public string SecondPersonPlural { get; set; }
        [Required]  
        public string ThirdPersonPlural { get; set; }
        [Required]
        public string EnglishTranslation { get; set; }

        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
