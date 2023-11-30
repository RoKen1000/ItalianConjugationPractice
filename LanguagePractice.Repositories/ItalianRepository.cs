using LanguagePractice.Repositories.IRepositories;

namespace LanguagePractice.Repositories
{
    public class ItalianRepository<T> : IItalianRepository<T> where T : class
    {
        public void Imperfect()
        {
            throw new NotImplementedException();
        }

        public void PresentIndicative()
        {
            throw new NotImplementedException();
        }

        public void PresentPerfect()
        {
            throw new NotImplementedException();
        }

        public int ProduceRandomOffset(string verbTense)
        {
            throw new NotImplementedException();
        }
    }
}
