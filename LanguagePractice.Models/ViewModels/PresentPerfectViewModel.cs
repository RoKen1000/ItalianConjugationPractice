using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Models.ViewModels
{
    public class PresentPerfectViewModel : BaseLanguageViewModel
    {
        [Required]
        public bool UsesEssere { get; set; }
    }
}
