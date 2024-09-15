using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Models.ViewModels
{
    public class ManagementIndexViewModel<T>
    {
        public ManagementIndexViewModel()
        {
            Entities = new List<T>();
        }

        public List<T> Entities { get; set; }
        public bool IsSuccess { get; set; }
    }
}
