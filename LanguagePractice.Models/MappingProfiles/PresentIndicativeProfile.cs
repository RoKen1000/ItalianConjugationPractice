using AutoMapper;
using LanguagePractice.Models.ViewModels;
using LanguagePracticeSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Models.MappingProfiles
{
    public class PresentIndicativeProfile : Profile
    {
        public PresentIndicativeProfile()
        {
            CreateMap<PresentIndicativeViewModel, PresentIndicative>().ReverseMap();
        }
    }
}
