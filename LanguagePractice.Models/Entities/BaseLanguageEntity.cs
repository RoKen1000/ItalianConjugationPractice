using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Models.Entities
{
   public abstract class BaseLanguageEntity
   {
        public int Id { get; set; }
        public string Infinitive { get; set; }
        public string FirstPersonSingular { get; set; }
        public string SecondPersonSingular { get; set; }
        public string ThirdPersonSingular { get; set; }
        public string FirstPersonPlural { get; set; }
        public string SecondPersonPlural { get; set; }
        public string ThirdPersonPlural { get; set; }
        public string EnglishTranslation { get; set; }
    }
}
