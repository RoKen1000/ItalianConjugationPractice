
namespace LanguagePractice.Repositories.IRepositories
{
    internal interface IItalianRepository
    {
        int ProduceRandomOffset(string verbTense);
        void PresentIndicative();
        void PresentPerfect();
        void Imperfect();
    }
}
