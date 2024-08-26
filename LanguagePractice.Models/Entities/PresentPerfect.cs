using LanguagePractice.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace LanguagePracticeSite.Models.Entities
{
    public class PresentPerfect : BaseLanguageEntity
    {
        public bool UsesEssere { get; set; }
    }
}
