﻿using LanguagePracticeSite.Models.Entities;

namespace LanguagePractice.Repositories.IRepositories
{
    public interface IItalianRepository
    {
        Task<PresentIndicative> GetPresentIndicative();
        Task<PresentPerfect> GetPresentPerfect();
        Task<Imperfect> GetImperfect();
    }
}
