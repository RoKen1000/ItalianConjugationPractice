﻿using System.ComponentModel.DataAnnotations;

namespace LanguagePracticeSite.Models
{
    public class PresentPerfect
    {
        [Key]
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
        public bool UsesEssere { get; set; }
        [Required]
        public string EnglishTranslation { get; set; }
    }
}
