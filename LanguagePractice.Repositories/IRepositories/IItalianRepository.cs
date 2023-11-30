
namespace LanguagePractice.Repositories.IRepositories
{
    internal interface IItalianRepository<T> where T : class
    {
        int ProduceRandomOffset(string verbTense);
        void PresentIndicative();
        void PresentPerfect();
        void Imperfect();
    }
}
