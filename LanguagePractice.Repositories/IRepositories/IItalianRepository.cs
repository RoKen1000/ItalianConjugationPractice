using LanguagePractice.Common.Result;
using LanguagePracticeSite.Models.Entities;

namespace LanguagePractice.Repositories.IRepositories
{
    public interface IItalianRepository
    {
        Task<Result<PresentIndicative>> GetPresentIndicative();
        Task<Result<PresentPerfect>> GetPresentPerfect();
        Task<Result<Imperfect>> GetImperfect();
    }
}
