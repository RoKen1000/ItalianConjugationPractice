using LanguagePracticeSite.Models;

namespace LanguagePractice.Repositories.IRepositories
{
    public interface IItalianRepository
    {
        Task<PresentIndicative> GetPresentIndicative();
        Task<PresentPerfect> GetPresentPerfect();
        Task<Imperfect> GetImperfect();
    }
}
