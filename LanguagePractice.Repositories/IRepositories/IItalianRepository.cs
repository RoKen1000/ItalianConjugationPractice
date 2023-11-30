using LanguagePracticeSite.Models;

namespace LanguagePractice.Repositories.IRepositories
{
    public interface IItalianRepository
    {
        int ProduceRandomOffset(string verbTense);
        PresentIndicative PresentIndicative();
        PresentPerfect PresentPerfect();
        Imperfect Imperfect();
    }
}
