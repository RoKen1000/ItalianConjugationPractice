using LanguagePractice.Models;
using System.ComponentModel.DataAnnotations;

namespace LanguagePracticeSite.Models
{
    public class PresentPerfect : GenericWord
    {
        [Required]
        public bool UsesEssere { get; set; }
    }
}
